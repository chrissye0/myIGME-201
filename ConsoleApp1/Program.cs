using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
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
            double imagCoord, realCoord, startRealCoord, endRealCoord, startImagCoord, endImagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

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
                startImagCoord = double.Parse(strStartImagCoord);
                endImagCoord = double.Parse(strEndImagCoord);
                startRealCoord = double.Parse(strStartRealCoord);
                endRealCoord = double.Parse(strEndRealCoord);

                if (startImagCoord > endImagCoord && startRealCoord < endRealCoord)
                {
                    for (imagCoord = startImagCoord; imagCoord >= endImagCoord; imagCoord -= ((startImagCoord - endImagCoord) / 48))
                    {
                        for (realCoord = startRealCoord; realCoord <= endRealCoord; realCoord += ((endRealCoord - startImagCoord) / 80))
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

            }
        }
    }
}