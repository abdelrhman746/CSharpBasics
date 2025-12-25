using System;

namespace Ticks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //number of 100-nanosecond intervals that have elapsed
            //since january 1, 0001 at 00:00:000 in the Gregorian calender

            DateTime dt1 = new DateTime();

            Console.WriteLine(DateTime.MinValue.Ticks);//min value of ticks
            Console.WriteLine(DateTime.MaxValue.Ticks);//max value of ticks

            Console.ReadKey();
        }
    }
}
