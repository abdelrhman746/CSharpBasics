using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 20;
            double myDouble = 7.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));     //CONVERT INT TO STRING 
            Console.WriteLine(Convert.ToDouble(myInt));     //CONVERT INT TO DOUBLE
            Console.WriteLine(Convert.ToInt32(myDouble));   //convert double into int
            Console.WriteLine(Convert.ToString(myBool));    //convert bool to string

            Console.ReadKey();
        }
    }
}
