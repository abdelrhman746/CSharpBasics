using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingEnums
{
    internal class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            thursday,
            Friday,
            Saturday,
            Sunday            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Friday); //output:Friday
            int day =(int)WeekDays.Friday; //enum to int conversion
            Console.WriteLine(day); //output: 4

            var wd = (WeekDays)5; //int to enum conversion

            Console.WriteLine(wd); //output:Saturday

            Console.ReadKey();

        }
    }
}
