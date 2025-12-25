using System;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Interpolatoion
            string firstName = "Abdelrhman";
            string lastName = "Fawzy";
            string code = "107";
            //you should use $ to $ to identify an interpolated string
            string fullName=$"Mr.{firstName} {lastName},Code:{code}";

            Console.WriteLine(fullName);

            Console.ReadKey();
        }
    }
}
