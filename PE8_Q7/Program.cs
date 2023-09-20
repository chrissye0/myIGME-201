using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Q7
{
    // Author: Christine Espeleta
    // Purpose: Take a string from the user and print it in reverse.
    // Restrictions: N/A
    internal class Program
    {
        // Purpose: Take a string from the user and print it in reverse.
        // Restrictions: N/A
        static void Main(string[] args)
        {
            // str to store user input
            // reverseStr to store reversed input string
            string str = "";
            string reverseStr = "";

            // get user input for str
            Console.Write("Please provide a string: ");
            str = Console.ReadLine();

            // start with last letter in string and end with the first letter
            // add each one to reverseStr
            for(int i = str.Length - 1; i >= 0; i--)
            {
                reverseStr = reverseStr + str[i];
            }
            // print the final result to the console
            Console.WriteLine("String in reverse: " + reverseStr);
        }
    }
}
