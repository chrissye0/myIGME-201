using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9_Q3
{
    // Author: Christine Espeleta
    // Purpose: Use delegate function to impersonate Console.ReadLine() when asking for user input.
    // Restrictions: N/A

    delegate string ReadLine();
    internal class Program
    {
        // Purpose: Use delegate function to impersonate Console.ReadLine() when asking for user input.
        // Restrictions: N/A
        static void Main(string[] args)
        {
            string input = null;
            Console.WriteLine("Please type a string.");
            ReadLine consoleProcess;
            consoleProcess = new ReadLine(report);
            input = consoleProcess();
            Console.WriteLine(input);
        }
        static string report()
        {
            return Console.ReadLine();
        }
    }
}
