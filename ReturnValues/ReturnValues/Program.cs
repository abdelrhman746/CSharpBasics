using System;


namespace ReturnValues
{
    internal class Program
    {
        static string GetMyName()
        {
            return "Abdelrhman Fawzy";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("My Name is {0}",GetMyName());

            Console.ReadKey ();
        }
    }
}
