using System;

namespace ExplicitCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 17.58;

            int myInt = (int)myDouble;// Manual Casting: double int

            Console.WriteLine(myDouble);  //Outputs 17.58
            Console.WriteLine(myInt);     //Outputs 17

            Console.ReadKey();
        }
    }
}
