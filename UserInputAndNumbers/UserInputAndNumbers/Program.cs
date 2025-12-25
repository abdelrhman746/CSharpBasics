using System;

namespace UserInputAndNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age?");
            //if you don't convert you will get error, and if you enter string you will get error
            int age=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is :" + age);

            Console.ReadKey();
        }
    }
}
