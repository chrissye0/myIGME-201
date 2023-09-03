using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: Christine Espeleta
    // Purpose: Bug squashing exercise
    // Restrictions: All number outputs are in the form of integers.
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            // int i = 0
            // SYNTAX ERROR - forgot the semicolon
            int i = 0;

            string allNumbers = null;

            // loop through the numbers 1 through 10
            // for (i = 1; i < 10; ++i)
            //LOGICAL ERROR - this for loop will exclude 10, so change i < 10 to i < 11 so 10 will be included in allNumbers
            for (i = 1; i < 11; ++i)
            {
                // declare string to hold all numbers
                //string allNumbers = null;
                // RUN-TIME ERROR - code would crash and not work, declare allNumbers outside of for loop

                // output explanation of calculation
                // Console.Write(i + "/" + i - 1 + " = ");
                // SYNTAX ERROR - fix by adding parentheses around i - 1
                Console.Write(i + "/" + (i - 1) + " = ");

                // RUN-TIME ERROR - code would crash and not work when i = 1
                // i / (i - 1) would generate an error since 1/0 is undefined
                // Fix this by using try and catch
                try
                {
                    // output the calculation based on the numbers
                    Console.WriteLine(i / (i - 1));
                }
                catch
                {
                    Console.WriteLine("UNDEFINED"); // if it generates an error, print UNDEFINED to console
                }

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                // i = i + 1;
                // LOGICAL ERROR - i is already incremented by 1 in the for loop, so including i = i + 1 here would be extra and skip some numbers
            }

            // output all numbers which have been processed
            // Console.WriteLine("These numbers have been processed: " allNumbers);
            // SYNTAX ERROR - Forgot to add a + between "These numbers have been processed: " and allNumbers 
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}