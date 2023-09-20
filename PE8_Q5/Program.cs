using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Q5
{
    internal class Program
    {
        // Author: Christine Espeleta
        // Purpose: Calculate z in z = 3y^2 + 2x - 1 using a 3D array.
        // Restrictions: N/A
        static void Main(string[] args)
        {
            // Purpose: Calculate z in z = 3y^2 + 2x - 1 using a 3D array.
            // Restrictions: N/A

            // calculating z = 3y^2 + 2x - 1
            // -1 <= x <= 1 in 0.1 increments --> 21 values of x
            // 1 <= y <= 4 in 0.1 increments --> 31 values of y

            double x = 0;
            double y = 0;
            double z = 0;

            int nX = 0;
            int nY = 0;

            // we declare our 3 dimensional array to hold:
            //        21 values of x
            //        31 values of y for each value of x
            //        3 values for each data point: the x, y and z

            double[,,] zFunc = new double[21, 31, 3];

            for (x = -1; x <= 1; x += 0.1, nX++)
            {
                x = Math.Round(x, 1);

                // start with the 0'th "y" bucket for this value of x
                nY = 0;

                for (y = 1; y <= 4; y += 0.1, ++nY)
                {
                    y = Math.Round(y, 1);

                    z = 3 * Math.Pow(x, 3) + 2 * Math.Pow(y, 3) - 1;

                    z = Math.Round(z, 3);

                    zFunc[nX, nY, 0] = x;
                    zFunc[nX, nY, 1] = y;
                    zFunc[nX, nY, 2] = z;
                }
            }

        }
    }
}
