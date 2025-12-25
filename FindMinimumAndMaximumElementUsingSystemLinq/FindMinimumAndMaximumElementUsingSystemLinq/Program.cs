using System;

using System.Linq;

namespace FindMinimumAndMaximumElementUsingSystemLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Note that we used System.linq above

            int[] numbers = { 51, -1, 2, 14, 18, 40, 178 };

            //get the minimum element
            Console.WriteLine("Smallest Element: "+numbers.Min());

            // Max() returns the largest number in array

            Console.WriteLine("Largest Element: "+numbers.Max());

            Console.ReadKey();
        }
    }
}
