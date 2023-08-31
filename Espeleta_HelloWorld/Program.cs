using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espeleta_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // print name to console
            Console.WriteLine("Christine Espeleta");
            // creating random integers
            int coolNumber = 1;
            int coolerNumber = 3;
            // print sum of integers
            Console.WriteLine(coolNumber + coolerNumber);
            //print difference of integers
            Console.WriteLine(coolNumber - coolerNumber);

            //if integer coolNumber is equal to 1, print something to console
            if (coolNumber == 1)
            {
                Console.WriteLine("That's pretty neat!");
            }

            //testing for loop by printing numbers to console
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
