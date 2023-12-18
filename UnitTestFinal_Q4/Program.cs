using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace UnitTestFinal_Q3
{
    // Author: Christine Espeleta
    // Final Unit Test Question #4
    // Using the console application created in #3, Implement a Depth First Search of this digraph starting from red and output the colors.

    enum Colors
    {
        LightBlue,
        Blue,
        Red,
        Gray,
        Orange,
        Purple,
        Yellow,
        Green
    }
    public class Program
    {
        static bool[,] mGraph = new bool[,]
        {                       // "Light Blue"  "Blue"  "Red"  "Gray"  "Orange"  "Purple"  "Yellow"  "Green"
                /* Light Blue */ {  false,        true,  false,  true,   false,    false,    false,    false },
                /* Blue */       {  true,         false,  false, false,  false,    false,    true,     false },
                /* Red */        {  false,        true,   false, true,   false,    false,    false,    false },
                /* Gray */       {  true,         false,  false, false,  true,     false,    false,    false },
                /* Orange */     {  false,        false,  false, false,  false,    true,     false,    false },
                /* Purple */     {  false,        false,  false, false,  false,    false,    true,     false },
                /* Yellow */     {  false,        false,  false, false,  false,    false,    false,    true  },
                /* Green */      {  false,        false,  false, false,  false,    false,    false,    false }
        };

        static int[][] lGraph = new int[][]
        {
            /* Light Blue */ new int[] { (int)Colors.Blue, (int)Colors.Gray },
            /* Blue */       new int[] { (int)Colors.LightBlue, (int)Colors.Yellow },
            /* Red */        new int[] { (int)Colors.Blue, (int)Colors.Gray },
            /* Gray */       new int[] { (int)Colors.LightBlue, (int)Colors.Orange },
            /* Orange */     new int[] { (int)Colors.Purple },
            /* Purple */     new int[] { (int)Colors.Yellow },
            /* Yellow */     new int[] { (int)Colors.Green },
            /* Green */      null
        };

        // the current numeric representation of the coin state
        static int nState = (int)Colors.Red;

        static void Main(string[] args)
        {
            // create a thread running DFS()
            Thread t = new Thread(DFS);
            t.Start();
        }

        static void DFSUtil(int v, bool[] visited)
        {
            // mark the current node as visited
            visited[v] = true;

            // print the color name of the current node
            Console.WriteLine(((Colors)v).ToString() + " ");

            // Recur for all the vertices
            // adjacent to this vertex if there are any
            int[] thisStateList = lGraph[v];
            if (thisStateList != null ) 
            { 
                foreach( int n in thisStateList )
                {
                    if (!visited[n])
                    {
                        DFSUtil(n, visited);
                    }
                }
            }
        }

        static void DFS()
        {
            // Mark all the vertices as not visited
            // (set as false by default in c#)
            bool[] visited = new bool[lGraph.Length];

            // Call the recursive helper function
            // to print DFS traversal
            DFSUtil(nState, visited);
        }
    }
}