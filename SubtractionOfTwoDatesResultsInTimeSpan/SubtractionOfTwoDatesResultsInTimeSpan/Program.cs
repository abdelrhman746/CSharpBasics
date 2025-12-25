using System;

namespace SubtractionOfTwoDatesResultsInTimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2025, 10, 23);
            DateTime dt2 = new DateTime(2025, 10, 28);

            TimeSpan result=dt2.Subtract(dt1);

            Console.WriteLine(result.Days);   

            Console.ReadKey();
        }
    }
}
