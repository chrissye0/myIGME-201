using System;

namespace Mandelbrot
{
    // Author: Christine Espeleta
    // Purpose: Generate Mandelbrot sets in the console window
    // Restrictions: N/A

    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>

    class Class1
    {
        // Purpose: Generate Mandelbrot sets in the console window
        // Restrictions: N/A

        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            // initialize doubles for coordinates and user inputs
            double imagCoord, realCoord, startRealCoord, endRealCoord, startImagCoord, endImagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            // collect user inputs and save them as strings
            Console.WriteLine("Provide a starting value for imagCoord (has to be greater than ending value). Default: 1.2");
            string strStartImagCoord = Console.ReadLine();
            Console.WriteLine("Provide an ending value for imagCoord (has to be less than starting value). Default: -1.2");
            string strEndImagCoord = Console.ReadLine();
            Console.WriteLine("Provide a starting value for realCoord (has to be less than ending value). Default: -0.6");
            string strStartRealCoord = Console.ReadLine();
            Console.WriteLine("Provide an ending value for realCoord (has to be greater than starting value). Default: 1.77");
            string strEndRealCoord = Console.ReadLine();

            try
            {
                // try to parse inputs as doubles
                startImagCoord = double.Parse(strStartImagCoord);
                endImagCoord = double.Parse(strEndImagCoord);
                startRealCoord = double.Parse(strStartRealCoord);
                endRealCoord = double.Parse(strEndRealCoord);

                // do this only if
                // startImagCoord is > endImagCoord
                // and startRealCoord is < endRealCoord
                if (startImagCoord > endImagCoord && startRealCoord < endRealCoord)
                {
                    // take code from Mandelbrot.cs but use new variables
                    // initialize imagCoord to startImagCoord, stop when imagCoord >= endImagCoord, adjust increment so there are 48 values
                    // initialize realCoord to startRealCoord, stop when realCoord <= endRealCoord, adjust increment so there are 80 values
                    for (imagCoord = startImagCoord; imagCoord >= endImagCoord; imagCoord -= ((startImagCoord - endImagCoord) / 48))
                    {
                        for (realCoord = startRealCoord; realCoord <= endRealCoord; realCoord += ((endRealCoord - startRealCoord) / 80))
                        {
                            iterations = 0;
                            realTemp = realCoord;
                            imagTemp = imagCoord;
                            arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                            while ((arg < 4) && (iterations < 40))
                            {
                                realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                                   - realCoord;
                                imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                                realTemp = realTemp2;
                                arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                                iterations += 1;
                            }
                            switch (iterations % 4)
                            {
                                case 0:
                                    Console.Write(".");
                                    break;
                                case 1:
                                    Console.Write("o");
                                    break;
                                case 2:
                                    Console.Write("O");
                                    break;
                                case 3:
                                    Console.Write("@");
                                    break;
                            }
                        }
                        Console.Write("\n");
                    }
                }
            }
            catch
            {
                // do nothing when there's an error
            }
        }
    }
}