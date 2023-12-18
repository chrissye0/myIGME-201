using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFinal_Q3
{
    // Author: Christine Espeleta
    // Final Unit Test Question #3
    // Create a console application and represent the following digraph as an adjacency matrix and an adjacency list.

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
        static int[,] mGraph = new int[,]
        {               // "Light Blue"  "Blue"  "Red"  "Gray"  "Orange"  "Purple"  "Yellow"  "Green"
        /* Light Blue */ {  -1,           1,      -1,    0,      -1,       -1,       -1,       -1 },
        /* Blue */       {  1,            -1,     -1,    -1,     -1,       -1,       8,        -1 },
        /* Red */        {  -1,           1,      -1,    5,      -1,       -1,       -1,       -1 },
        /* Gray */       {  0,            -1,     -1,    -1,     1,        -1,       -1,       -1 },
        /* Orange */     {  -1,           -1,     -1,    -1,     -1,       1,        -1,       -1 },
        /* Purple */     {  -1,           -1,     -1,    -1,     -1,       -1,       1,        -1 },
        /* Yellow */     {  -1,           -1,     -1,    -1,     -1,       -1,       -1,       6  },
        /* Green */      {  -1,           -1,     -1,    -1,     -1,       -1,       -1,       -1 }
        };

//        static bool[,] mGraph = new bool[,]
//{                       // "Light Blue"  "Blue"  "Red"  "Gray"  "Orange"  "Purple"  "Yellow"  "Green"
//        /* Light Blue */ {  false,        true,  false,  true,   false,    false,    false,    false },
//        /* Blue */       {  true,         false,  false, false,  false,    false,    true,     false },
//        /* Red */        {  false,        true,   false, true,   false,    false,    false,    false },
//        /* Gray */       {  true,         false,  false, false,  true,     false,    false,    false },
//        /* Orange */     {  false,        false,  false, false,  false,    true,     false,    false },
//        /* Purple */     {  false,        false,  false, false,  false,    false,    true,     false },
//        /* Yellow */     {  false,        false,  false, false,  false,    false,    false,    true  },
//        /* Green */      {  false,        false,  false, false,  false,    false,    false,    false }
//};
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

        static void Main(string[] args)
        {

        }
    }
}
