using System;

namespace Method_Parameters
{
    internal class Program
    {
        static void PrintMyInfo(string Name,byte Age)
        {
            Console.WriteLine("Name= {0}, Age= {1}",Name, Age);
        }
        static void Main(string[] args)
        {
            PrintMyInfo("Abdelrhman Fawzy", 30);

            Console.ReadKey();
        }
    }
}
