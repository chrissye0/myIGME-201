using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2_Q12
{
    // Author: Christine Espeleta
    // Purpose: Unit Test 2 Question #12 - Output contents of a SortedList containing names and formatted birthdays (MM/dd/yyyy)
    // Restrictions: N/A
    static class Program
    {
        static void Main(string[] args)
        {   
            // create sorted list containing string and DateTime
            SortedList<string, DateTime> friendBirthdays = new SortedList<string, DateTime>();
            // add 3 names and birthdays
            friendBirthdays.Add("Alice", new DateTime(2003, 3, 1));
            friendBirthdays.Add("Barry", new DateTime(2004, 12, 15));
            friendBirthdays.Add("Chris", new DateTime(2005, 7, 11));
            // use a foreach loop to print them all the console
            foreach (KeyValuePair<string, DateTime> valuePair in friendBirthdays)
            {
                Console.WriteLine($"Person: {valuePair.Key} \nBirthday: {valuePair.Value.ToString("MM/dd/yyyy")}");
            }   
        }
    }
}
