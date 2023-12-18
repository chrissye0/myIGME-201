using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFinal_Q1
{
    // Author: Christine Espeleta
    // Final Exam Question #1
    // C# provides us with a Stack<int> generic template to create a stack of integers.  Write your own MyStack class in a console app that contains a List<int> and implements the three Stack methods: Push(int n), Pop() and Peek() using the List<int>.  You may not use Stack<int> in your solution.

    public class Program
    {
        static void Main(string[] args)
        {
            // using an actual Stack
            Stack myStackO = new Stack();
            myStackO.Push(1);
            myStackO.Push(2);
            myStackO.Push(3);
            myStackO.Push(4);
            foreach (int i in myStackO)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("popped " + myStackO.Pop());
            Console.WriteLine("peeked " + myStackO.Peek());

            Console.WriteLine();

            //testing my stack class
            MyStack myStack = new MyStack();
            // insert or "push" ints at the beginning of the list
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.stack.ForEach(Console.WriteLine);
            // remove or "pop" the first int in the list and return it
            Console.WriteLine("popped " + myStack.Pop());
            // return or "peek" at the first int in the list
            Console.WriteLine("peeked " + myStack.Peek());
        }
    }

    public class MyStack
    {
        public List<int> stack = new List<int> {};

        // Push stack method - insert int at the beginning of the list
        public void Push(int n)
        {
            stack.Insert(0, n);
        }

        // Pop stack method - remove first int in list and return it
        public int Pop()
        {
            int poppedInt = stack[0];
            stack.RemoveAt(0);
            return poppedInt;
        }

        // Peek stack method - return first int in list
        public int Peek()
        {
            int peekedInt = stack[0];
            return peekedInt;
        }
    }
}