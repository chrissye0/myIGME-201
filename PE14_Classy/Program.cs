using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14_Classy
{
    // Class: Program
    // Author: Christine Espeleta
    // Purpose: PE 14 Classy Questions #2 and #3. Create a console application with an interface and 2 classes inheriting the interface.
    // Restrictions: N/A
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create objects of both classes
            Class1 obj1 = new Class1();
            Class2 obj2 = new Class2();

            // Call MyMethod with each object
            MyMethod(obj1);
            MyMethod(obj2);
        }

        // #3 - Include public static void method that uses the interface to call the common method name
        public static void MyMethod(object myObject)
        {
            MyInterface myInterface = (MyInterface)myObject;
            myInterface.Method();
        }
    }

    public class Class1 : MyInterface
    {
        // Inherit method defined by interface
        // Personalize code block to Class 1
        public void Method()
        {
            Console.WriteLine("This is Class 1.");
        }
    }

    public class Class2 : MyInterface
    {
        // Inherit method defined by interface
        // Personalize code block to Class 2
        public void Method()
        {
            Console.WriteLine("This is Class 2.");
        }
    }

    // Interface, inherited by Class1 and Class2
    public interface MyInterface
    {
        void Method();
    }
}
