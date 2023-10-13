using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PE12_Q3
{
    // Author: Christine Espeleta
    // Purpose: PE 12 Questions 1, 2, and 3
    // Restrictions: N/A
    internal class Program
    {
        static void Main(string[] args)
        {
            // create class instance
            MyDerivedClass bigString = new MyDerivedClass();
            // set string value
            bigString.MyString = "abc";
            // print derived class' override of the base class' GetString method
            Console.WriteLine(bigString.GetString());
        }
    }
    public class MyClass
    {
        private string myString;
        // MyString property - use set "write" command
        public virtual string MyString
        {
            get
            {
                return myString;
            }
            set
            {
                myString = value;
            }

        }

        // GetString method - return string
        public virtual string GetString()
        {
            return myString;
        }
    }

    // MyDerivedClass - class derived from MyClass, append something to return string
    public class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            return base.GetString() + "(output from the derived class)";
        }

    }
}
