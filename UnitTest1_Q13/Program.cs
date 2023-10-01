using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1_Q12
{
    // Class: Program
    // Author: Christine Espeleta
    // Purpose: Unit 1 Test Question #13
    // Restrictions: N/A
    static internal class Program
    {
        // Method: Main()
        // Purpose: Ask the user for their name, and depending on their answer give them a raise.
        // Same purpose as #12, but instead use struct.
        // Restrictions: N/A

        // create a struct to store sName and dSalary as properties
        struct Employee
        {
            public string sName;
            public double dSalary;
        }
        static void Main(string[] args)
        {
            // use Employee struct
            Employee e = new Employee();
            e.dSalary = 30000;
            // Ask the user for their name and store it in sName
            Console.Write("What is your name? ");
            e.sName = Console.ReadLine();


            // If GiveRaise returns true, add $19,999 to their salary and print this to console
            if (GiveRaise(e))
            {
                e.dSalary += 19999.99;
                Console.WriteLine("Congrats! Your new salary is $" + e.dSalary);
            }
        }
        static bool GiveRaise(Employee x)
        {
            // If their name is Chris, return true
            if (x.sName == "Chris")
            {
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