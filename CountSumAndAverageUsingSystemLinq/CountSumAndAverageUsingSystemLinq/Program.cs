using System;

using System.Linq;

namespace CountSumAndAverageUsingSystemLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Note that we used System.Linq above.

            int[] numbers = { 20, 22, 19, 18, 1 };

            //Compute Count
            Console.WriteLine("Count: "+numbers.Count());

            //Compute Sum
            Console.WriteLine("Sum: " + numbers.Sum());

            //Compute Average
            Console.WriteLine("Average: " + numbers.Average());

            Console.ReadKey();
        }
    }
}
