using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PE3_VariablesAndExpressions
{
    // Author: Christine Espeleta
    // Purpose: Take 4 user integer inputs and calculate their product.
    // Restrictions: Error occurs when the user inputs a value that isn't a number.
    internal class Program
    {
        // Purpose: Take 4 user integer inputs and calculate their product.
        // Restrictions: Error occurs when the user inputs a value that isn't a number.
        static void Main(string[] args)
        {
            // take 4 inputs from the user through the console and save them as strings
            Console.WriteLine("Please enter an integer.");
            string sNum1 = Console.ReadLine();
            Console.WriteLine("Please enter an integer.");
            string sNum2 = Console.ReadLine();
            Console.WriteLine("Please enter an integer.");
            string sNum3 = Console.ReadLine();
            Console.WriteLine("Please enter an integer.");
            string sNum4 = Console.ReadLine();

            // convert all string inputs into integers
            int iNum1 = Convert.ToInt32(sNum1);
            int iNum2 = Convert.ToInt32(sNum2);
            int iNum3 = Convert.ToInt32(sNum3);
            int iNum4 = Convert.ToInt32(sNum4);

            // print the product of all integers
            Console.WriteLine("Product: " + (iNum1 * iNum2 * iNum3 * iNum4));
        }
    }
}