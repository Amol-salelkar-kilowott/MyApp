using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    public class Program
    {


        public static void Main(string[] args)
        {
            int[] a = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
            int n = a.Length;

            Console.Write("Mean = " + Assignment.FindMean(a, n) + "\n");
            Console.Write("Median = " + Assignment.FindMedian(a, n) + "\n");
            Console.Write("Median = " + Assignment.Findmode(a, n) + "\n");

        }
    }
}


       


