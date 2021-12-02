using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    public class Program
    {
        static readonly int[] data = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };

        public static void Main(string[] args)
        {
            
            var spobject = new stats();
            spobject.Numbers = data;
            var Sum = spobject.Calculatesum();
           
            Console.WriteLine($"sum: {Sum}");

            var mean =spobject.Calculatemean();
            Console.WriteLine($"Mean: {mean}");


            var median= spobject.Calculatemedian();
            Console.WriteLine($"Medain: {median}");

            var mode = spobject.Calculatemedian();
            Console.WriteLine($"Mode: {mode}");


        }
    }
}


       


