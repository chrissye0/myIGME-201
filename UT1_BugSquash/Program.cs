using System;

namespace UT1_BugSquash
{
    // Class: Program
    // Author: Christine Espeleta
    // Purpose: Unit 1 Test Question #14
    // Restrictions: N/A
    class Program
    {
        // Method: Main()
        // Purpose: Calculate x^y for y > 0 using a recursive function
        // Restrictions: N/A
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            // Declare nY
            // Compile-time error: missing the semi-colon
            // int nY
            int nY;
            int nAnswer;

            // Print a line to console
            // Compile-time error: missing the quotes around the line.
            // Console.WriteLine(This program calculates x ^ y.);
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                // Get user input and set it to sNumber
                // Compile-time error: forgot to set the value to sNumber
                // Console.ReadLine();
                sNumber = Console.ReadLine();
            }  while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } // while (int.TryParse(sNumber, out nX));
            // Set nY to parsed sNumber
            // Compile-time error: Running this instead sets the new parsed sNumber to nX and not nY, and nY is not assigned a value
            // Run-time error: Because there is no ! in front of int.TryParse, the program will repeatedly ask for y as long as sNumber can be parsed. The program will continue with the rest of the code if sNumber cannot be parsed as an int.
            while (!int.TryParse(sNumber, out nY));

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            // Print an interpolated string.
            // Logic error: The program printed the wrong string since it was not interpolated, including nX and nY and not their values.
            //Console.WriteLine("{nX}^{nY} = {nAnswer}");
            Console.WriteLine($"{nX}^{nY} = {nAnswer}");
        }

        // Create a class for exponents.
        // Compile-time error: Forgot to declare static class type
        // int Power(int nBase, int nExponent)
        static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                // Logic error: Would result in the output always being 0.
                // returnVal = 0;
                return 1;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                // Run-time error: Would result in a stack overflow exception
                // nextVal = Power(nBase, nExponent + 1);
                nextVal = Power(nBase, nExponent - 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }
            // return the value of returnVal
            // Compile-time error: forgot to type return and the class doesn't return anything
            // returnVal;
            return returnVal;
        }
    }
}
