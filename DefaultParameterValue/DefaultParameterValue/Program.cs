using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultParameterValue
{
    internal class Program
    {
        static void PrintMyInfo(string Name,byte Age,string Address="No Address")
        {
            Console.WriteLine("Name= {0} , Age= {1} , Address= {2}",Name,Age,Address);
        }
        static void Main(string[] args)
        {
            //First we did not provide the it's optional
            PrintMyInfo("Abdelrhman Fawzy", 30);

            //Second we provide the address
            PrintMyInfo("Abdelrhman Fawzy", 30,"Amman-Jordan");

            Console.ReadKey();

        }
    }
}
