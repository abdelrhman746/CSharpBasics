using System;

namespace SetDateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();
            
            //assigns year, month, day
            DateTime dt2 = new DateTime(2025,10,23);

            //assigns year, month, day, hour, minute, seconds
            DateTime dt3 = new DateTime(2025, 10, 23, 10, 18, 22);

            //assigns year, month, day, hour, minute, seconds, local timezone
            DateTime dt4 = new DateTime(2025, 10, 23, 9, 18, 22, DateTimeKind.Utc);


            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);

            Console.ReadKey();
        }
    }
}
