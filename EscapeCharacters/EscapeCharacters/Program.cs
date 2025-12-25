using System;

namespace EscapeCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Useful Escape Characters:\n");

            //Newline
            Console.WriteLine("NewLine");
            Console.WriteLine("Welcome to \n Programming advices\n");

            //Tab
            Console.WriteLine("Tab:");
            Console.WriteLine("Welcome to \t Proramming advices\n");

            //Backspace
            Console.WriteLine("Backspace:");
            Console.WriteLine("Welcome to \bProramming advices\n");

            //Single quote
            Console.WriteLine("Single quote:");
            Console.WriteLine("Welcome to \' Proramming advices\n");

            //Double quote
            Console.WriteLine("Double quote:");
            Console.WriteLine("Welcome to \" Proramming advices\n");

            //Backslash
            Console.WriteLine("Backslash:");
            Console.WriteLine("Welcome to \\ Proramming advices\n");

            //Alert
            Console.WriteLine("Alert:");
            Console.WriteLine("\a");

            Console.ReadKey();
        }
    }
}
