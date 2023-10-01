using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1_Q3
{
    // create a custom delegate type that can point to a method accepting both a double and an int
    delegate int MathRounder(double n1, int n2);
    // Class: Program
    // Author: Christine Espeleta
    // Purpose: Unit Test 1 Question #3
    // Restrictions: N/A
    internal class Program
    {
        // Method: Main()
        // Purpose: Create a delegate impersonating Math.Round(double, int)
        // Restrictions: N/A
        static void Main(string[] args)
        {
            // string variables for user inputs
            string sNumber1 = null;
            string sNumber2 = null;
            // making one a double and one an int
            double nNum1 = 0;
            int nNum2 = 0;
            // double to store final answer
            double nAnswer = 0;

            // do this until one input can be parsed into a double and the other an int
            do
            {
                Console.Write("Enter a number you want to round. ");
                sNumber1 = Console.ReadLine();
                Console.Write("How many decimal places do you want to round to? ");
                sNumber2 = Console.ReadLine();

            } while (!double.TryParse(sNumber1, out nNum1) || !int.TryParse(sNumber2, out nNum2));

            Func<double, int, double> processRound;
            Action<double> outputAnswer;
            outputAnswer = new Action<double>(OutputAnswer);

            // processRound delegate method
            // return Math.Round of two parameters
            processRound = (n1, n2) =>
            {
                return Math.Round(n1, n2);
            };

            // use processRound on parsed user inputs
            nAnswer = processRound(nNum1, nNum2);
            outputAnswer(nAnswer);
            
        }
        // for printing the output to the console
        static void OutputAnswer(double iAnswer)
        {
            Console.WriteLine("Your number rounded is: {0}", iAnswer);
        }
    }
}
