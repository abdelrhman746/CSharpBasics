using System;

namespace GetCurrentDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime();
            dt1 = DateTime.Now;

            Console.WriteLine(dt1);

            Console.ReadKey();
        }
    }
}
