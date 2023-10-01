using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[][] dArray = new double[2][];
            dArray[1] = new double[2];
            dArray[0] = new double[1];

            dArray[0][0] = 15;
            dArray[1][0] = 5.67;
        }
    }
}
