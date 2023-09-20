using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Q9
{
    // Author: Christine Espeleta
    // Purpose: Place quotation marks around every word in a string.
    // Restrictions: N/A
    internal class Program
    {
        // Author: Christine Espeleta
        // Purpose: Place quotation marks around every word in a string.
        // Restrictions: N/A
        static void Main(string[] args)
        {
            // create string array to store user input
            string[] str = null;
            Console.WriteLine("Please write a string of words.");

            // make each word an individual string in the string array
            str = Console.ReadLine().Split(' ');

            // set new string to input string array size
            string[] newStr = new string[str.Length];

            // set following new strings to input strings with quotation marks
            for (int i = 0; i < (str.Length); i++)
            {
                newStr[i] = "\"" + str[i] + "\"";
            }

            // print it to console
            for (int i = 0; i < newStr.Length; i++)
            {
                Console.Write(newStr[i] + " ");
            }
        }
    }
}
