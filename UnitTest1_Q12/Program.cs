using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1_Q12
{
    // Class: Program
    // Author: Christine Espeleta
    // Purpose: Unit 1 Test Question #12
    // Restrictions: N/A
    static internal class Program
    {
        // Method: Main()
        // Purpose: Ask the user for their name, and depending on their answer give them a raise.
        // Restrictions: N/A
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;
            // Ask the user for their name and store it in sName
            Console.Write("What is your name? ");
            sName = Console.ReadLine();

            // If GiveRaise returns true, print this to console
            if (GiveRaise(sName, ref dSalary))
            {
                Console.WriteLine("Congrats! Your new salary is " + dSalary);
            }
        }
        static bool GiveRaise(string name, ref double salary) {
            // If their name is Chris, add $19,999 to their salary and return true
            if (name == "Chris")
            {
                salary += 19999.99;
                return true;
            }
            // Otherwise return false
            else
            {
                return false;
            }
        }
    }
}
