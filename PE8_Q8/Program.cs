using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Q8
{
    // Author: Christine Espeleta
    // Purpose: Accept a string from the user and do a case-insensitive replacement of all occurrences of the word "no" with "yes"
    // Restrictions: N/A
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a string array
            string[] str = null;
            // get user input
            Console.WriteLine("Please print a string with the word no.");
            // fill array with each word in user input (checking for spaces)
            str = Console.ReadLine().Split(' ');
            for (int i = 0; i < str.Length; i++)
            {
                // convert to lower case because it's case-insensitive
                str[i] = str[i].ToLower();
                // check to see if the string contains no
                if (str[i].Contains("no"))
                {
                    // replace no with yes
                    str[i] = str[i].Replace("no", "yes");
                }
                // print strings in console
                Console.Write(str[i] + " ");
            }
            
        }
    }
}
