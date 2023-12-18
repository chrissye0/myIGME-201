using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFinal_Q2
{
    // Author: Christine Espeleta
    // Final Exam Question #2
    // Modify the console app in #1 to create your own MyQueue class that contains a List<int> and implements the three Queue methods: Enqueue(int n), Dequeue() and Peek() using the List<int>.  You may not use Queue<int> in your solution.

    public class Program
    {
        static void Main(string[] args)
        {
            // using an actual Queue
            Queue myQueueO = new Queue();
            myQueueO.Enqueue(1);
            myQueueO.Enqueue(2);
            myQueueO.Enqueue(3);
            myQueueO.Enqueue(4);
            foreach (int i in myQueueO)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("dequeued " + myQueueO.Dequeue());
            Console.WriteLine("peeked " + myQueueO.Peek());

            Console.WriteLine();

            // testing my queue class
            MyQueue myQueue = new MyQueue();
            // add or "enqueue" ints at the end of the list
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.queue.ForEach(Console.WriteLine);
            // remove or "dequeue" the first int in the list and return it
            Console.WriteLine("dequeued " + myQueue.Dequeue());
            // return or "peek" at the first int in the list
            Console.WriteLine("peeked " + myQueue.Peek());
        }
    }

    public class MyQueue
    {
        public List<int> queue = new List<int> { };

        // Enqueue queue method - add int at the end of the list
        public void Enqueue(int n)
        {
            queue.Add(n);
        }

        // Dequeue queue method - remove first int in the list and return it
        public int Dequeue()
        {
            int dequeuedInt = queue[0];
            queue.RemoveAt(0);
            return dequeuedInt;
        }

        // Peek queue method - return first int in the list
        public int Peek()
        {
            int peekedInt = queue[0];
            return peekedInt;
        }
    }
}