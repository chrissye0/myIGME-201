using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4FlowControl
{
    // Author: Christine Espeleta
    // Purpose: Obtain two numbers from the user and display them
    // But reject any input where both numbers are greater than 10 and ask for two new numbers
    // Restrictions: N/A
    internal class Program
    {
        // Purpose: Obtain two numbers from the user and display them
        // But reject any input where both numbers are greater than 10 and ask for two new numbers
        // Restrictions: N/A
        static void Main(string[] args)
        {
            // strings to store user inputs
            string sInput1 = null;
            string sInput2 = null;
            // integers to store strings converted to integers
            int iInput1 = 0;
            int iInput2 = 0;
            // initial boolean value that dictates while loop
            bool result = false;
            while (result == false)
            {
                // ask user for inputs and store them into string variables
                Console.Write("Enter an integer: ");
                sInput1 = Console.ReadLine();
                Console.Write("Enter an integer: ");
                sInput2 = Console.ReadLine();
                try
                {
                    // try to convert user inputs to integers
                    iInput1 = Convert.ToInt32(sInput1);
                    iInput2 = Convert.ToInt32(sInput2);
                    // print the integers if both are <= 10 (or not > 10)
                    if (iInput1 <= 10 && iInput2 <= 10)
                    {
                        Console.WriteLine(iInput1);
                        Console.WriteLine(iInput2);
                        result = true;
                    }
                }
                catch
                {
                    // do nothing
                    // loop back around with try
                }
            }
        }
    }
}
