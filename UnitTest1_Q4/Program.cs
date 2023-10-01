using System.IO;
using System.Timers;
using System;
using System.Configuration;

namespace UnitTest1_Q4
{
    // Class: Program
    // Author: Christine Espeleta
    // Purpose: Unit Test 1 Question #4
    //Restrictions: N/A
    class Program
    {
        // create timer to check if time is out
        static bool bTimeOut = false;
        // make timer
        static Timer timeOutTimer;
        // create array of questions and int to store question #
        static string[,] Questions = { { "What is your favorite color?", "Black" }, { "What is the answer to life, the universe, and everything?", "42" }, { "What is the airspeed velocity of an unladen swallow?", "What do you mean? African or European swallow?" } };
        static int nQuestionNum;

        // Method: Main()
        // Purpose: Ask the user a question, check it, and integrate a timer.
        // Restrictions: N/A
        static void Main(string[] args)
        {
            // variables for string question number, user input,and if the user wants to play again
            string sQuestionNum;
            string userInput;
            string sAgain;

        start:
            // ask the user for the question number and keep going until it can be parsed into an integer or until the integer is between 1 and 3
            Console.WriteLine("Choose your question (1-3): ");
            do
            {
                sQuestionNum = Console.ReadLine();
                if (!int.TryParse(sQuestionNum, out nQuestionNum) || int.Parse(sQuestionNum) < 1 || int.Parse(sQuestionNum) > 3)
                {
                    Console.WriteLine("Please enter a number between 1 and 3.");
                }
                else
                {
                    break;
                }
            } while (true);

            // make 5 second timer start
            timeOutTimer = new Timer(5000);
            timeOutTimer.Elapsed += new ElapsedEventHandler(TimesUp);
            bTimeOut = false;
            timeOutTimer.Start();
            do
            {
                // prompt the user with a question
                Console.WriteLine("You have 5 seconds to answer the following question.");
                Console.WriteLine(Questions[nQuestionNum - 1, 0]);
                userInput = Console.ReadLine();
                timeOutTimer.Stop();
                // if they got it right, print this to console
                if (userInput == Questions[nQuestionNum - 1, 1])
                {
                    Console.WriteLine("Well done!");
                }
                else if (!bTimeOut)
                {
                    Console.WriteLine("Wrong! The answer is: " + Questions[nQuestionNum - 1, 1]);
                }
                // prompt if they want to play again
                Console.WriteLine("Do you want to play again? ");
                sAgain = Console.ReadLine();
                if (sAgain.ToLower().StartsWith("y"))
                {
                    goto start;
                }
                else if (sAgain.ToLower().StartsWith("n"))
                {
                    break;
                }
            } while (true);
        }
        // what happens when the timer runs out
        static void TimesUp(object source, ElapsedEventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine("Time's up!");
            Console.WriteLine("The answer is: " + Questions[nQuestionNum - 1, 1]);
            Console.WriteLine("Please press Enter.");
            bTimeOut = true;
            timeOutTimer.Stop();
        }
    }
}
