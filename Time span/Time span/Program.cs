using System;

namespace Time_span
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2025, 10, 23);

            //Hours, Minute, Seconds
            TimeSpan ts = new TimeSpan(1, 5, 1,50);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Hours);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Seconds);

            //this willadd time span to the date.

            DateTime newDate = dt.Add(ts);

            Console.WriteLine(newDate);

            Console.ReadKey();
        }
    }
}
