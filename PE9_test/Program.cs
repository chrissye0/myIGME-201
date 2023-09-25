using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PE9_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        struct Order
        {
            public string itemName;
            public int unitCount;
            public double unitCost;
            public double totalCost;
            
            public string answer;


            public double Price
            {
                get
                {
                    return totalCost;
                }
                set
                {
                    totalCost = unitCount * unitCost;
                }
            }
            public string formattedString
            {
                get
                {
                    return answer;
                }
                set
                {
                    answer = unitCount.ToString() + " " + itemName.ToString() + " items at $" + unitCost.ToString() + " each, total cost $" + totalCost.ToString(); 
                }
            }
        }


    }
}
