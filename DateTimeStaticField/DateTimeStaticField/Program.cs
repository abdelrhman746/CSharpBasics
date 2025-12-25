using System;

namespace DateTimeStaticField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime= DateTime.Now; //returns current date and time 

            DateTime todaysdate = DateTime.Today; //returns today's date

            DateTime currentDateTimeUTC = DateTime.UtcNow; //returns current UTC date and time

            DateTime maxDateTimeValue = DateTime.MaxValue; //returns max value of DateTime

            DateTime minDateTimeValue = DateTime.MinValue; //returns min value of DateTime

            Console.WriteLine("current DateTime: " + currentDateTime);

            Console.WriteLine("Today: " + todaysdate);

            Console.WriteLine("currentDateTimeUTC: " + currentDateTimeUTC);

            Console.WriteLine("minDateTimeValue: " + minDateTimeValue);

            Console.WriteLine("maxDateTimeValue: " + maxDateTimeValue);

            Console.ReadKey();
        }
    }
}
