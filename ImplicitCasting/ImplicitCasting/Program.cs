using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 17;

            double mydouble = myInt; //Automatic casting int to double

            Console.WriteLine(myInt);

            Console.WriteLine(mydouble);

            Console.ReadLine();

        }
    }
}
