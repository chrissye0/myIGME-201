using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Web;
using System.Web.UI.WebControls;
using Newtonsoft.Json.Linq;

namespace TriviaApp
{
    class TriviaResult
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;

    }
    class Trivia
    {
        public int response_code;
        public List<TriviaResult> results;
    }
    // {"response_code":0,
    // "results":[{"type":"multiple","difficulty":"easy","category":"Science &amp; Nature",
    // "question":"How many chromosomes are in your body cells?",
    // "correct_answer":"23",
    // "incorrect_answers":["21","22","24"]
    // }]}
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = null;
            string s = null;

            HttpWebRequest request;
            HttpWebResponse response;
            StreamReader reader;

            url = "https://opentdb.com/api.php?amount=1&type=multiple";

            request = (HttpWebRequest)WebRequest.Create(url);
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());    
            s = reader.ReadToEnd();
            reader.Close();

            Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);

            trivia.results[0].question = HttpUtility.HtmlDecode(trivia.results[0].question);
            trivia.results[0].correct_answer = HttpUtility.HtmlDecode(trivia.results[0].correct_answer);

            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; ++i)
            {
                trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].incorrect_answers[i]);
            }

            // ask the question
            Console.WriteLine(trivia.results[0].question);

            // create list to hold answer options
            List<string> options = new List<string>();

            // add incorrect answers to the list
            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; ++i)
                {
                options.Add(trivia.results[0].incorrect_answers[i]);
            }

            // insert correct answer in a random index
            Random rand = new Random();
            int index = rand.Next(options.Count+1);
            options.Insert(index, trivia.results[0].correct_answer);

            // convert list to array
            String[] optionsString = options.ToArray();

            // print each string in the array to the conaole
            foreach (string option in optionsString)
            {
                Console.WriteLine(option);
            }

            Console.WriteLine();

            // if answer is correct
            // not case sensitive
            if(Console.ReadLine().ToUpper() == trivia.results[0].correct_answer.ToUpper())
            {
                Console.WriteLine("Correct!");
            }
            // if it is incorrect
            else
            {
                Console.WriteLine("Incorrect! The right answer is " + trivia.results[0].correct_answer);
            }
        }
    }
}
