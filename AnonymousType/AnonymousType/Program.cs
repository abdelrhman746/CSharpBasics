using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //you don't specify any type here, automatically will be specified
            var student = new { Id = 20, FirstName = "Abdelrhman", LastName = "Abu-Hadhoud" };

            Console.WriteLine("Example1:\n");
            Console.WriteLine(student.Id); //output: 20
            Console.WriteLine(student.FirstName);//output: Abdelrhman
            Console.WriteLine(student.LastName);//output: Fawzy

            //you can print like this:
            Console.WriteLine(student);

            //anonymous type's property are read-only
            //you cannot change the values of properties as they are read-only.

            //student.Id =2;//Error: cannot change value
            //student.FirstName;//Error: cannot change value

            //An anonymous type's property can include another anonymous type.
            var student2 = new
            {
                Id = 20,
                FirstName = "Abdelrhman",
                LastName = "Fawzy",
                Address = new { Id = 1, City = "Cairo", Country = "Egypt" }
            };

            Console.WriteLine("Example2:\n");
            Console.WriteLine(student2.Id);
            Console.WriteLine(student2.FirstName);
            Console.WriteLine(student2.LastName);

            Console.WriteLine(student2.Address.Id);
            Console.WriteLine(student2.Address.City);
            Console.WriteLine(student2.Address.Country);

            Console.WriteLine(student2.Address);

            Console.ReadKey ();


        }
    }
}
