using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorsAndNumbers
{
    namespace Colors
    {
        enum EColors
        {
            red,
            orange,
            yellow,
            green,
            blue,
            indigo,
            violet
        }
    }

    namespace Numbers
    {
        enum ENumbers
        {
            one,
            two,
            three,
            four,
            five,
            six,
            seven
        }
    }
}

namespace FavoriteColorAndNumber
{
    using ColorsAndNumbers.Colors;

    using ColorsAlias = ColorsAndNumbers.Colors;

    static internal class Program
    {

        static void WriteMyVar(ref int nParameter)
        {
            Console.WriteLine(nParameter);

            nParameter = 42;

        }

        static void Main(string[] args)
        {
            ColorsAlias.EColors eColors;


            Console.WriteLine("");

            int myInt = 0;
            int anotherInt = 2;
            string sFavoriteColor = null;
            string sFavoriteNumber = "";
            bool bValid = false;
            int? nFavoriteNumber = null;

            anotherInt = myInt;

            WriteMyVar(ref myInt);

            // 3 errors
            // 1. syntax errors (missing semicolon)
            // 2. logical (code works but doesn't do the right thing)
            // 3. run-time errors (code crashes!)

            // prompt the user for their favorite color
            Console.Write("Hello! Please enter your favorite color: ");

            // read the favorite color from the user and store it in a variable
            sFavoriteColor = Console.ReadLine();

            // prompt the user for their favorite number
            Console.Write("Please enter your favorite number: ");

            // read their favorite color into a variable
            sFavoriteNumber = Console.ReadLine();

            //while (bValid == false)
            //{
            //}
            while (nFavoriteNumber == null)
            {
                try
                {
                    nFavoriteNumber = Convert.ToInt32(sFavoriteNumber);
                }
                catch
                {
                    Console.WriteLine("Please enter an integer.");
                }
            }

            // a loop that outputs their favorite color and favorite number n times
        
        }
    }
}
