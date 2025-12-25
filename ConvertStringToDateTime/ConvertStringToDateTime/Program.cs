using System;

namespace ConvertStringToDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = "10/23/2025";
            DateTime dt;

            var isValidDate=DateTime.TryParse(str, out dt);

            if(isValidDate)
            {
                Console.WriteLine(dt);
            }
            else
            {
                Console.WriteLine($"{str} is not a valid date string");
            }

            //invalid string date
            var str2 = "10/65/2025";
            DateTime dt2;

            var isValidDate2 = DateTime.TryParse(str2, out dt2);

            if (isValidDate2)
            {
                Console.WriteLine(dt2);
            }
            else
            {
                Console.WriteLine($"{str2} is not a valid date string");
            }

            Console.ReadKey();
        }
    }
}
