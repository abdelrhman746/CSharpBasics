using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Program
    {
        struct stSudent
        {
            public string FirstName;
            public string LastName;
        }
        static void Main(string[] args)
        {
            //A struct object can be created with or without the operator,
            //same as primitive type variables.

            stSudent Student;
            stSudent Student2 =new stSudent();

            Student.FirstName = "Abdelrhman";
            Student.LastName = "Fawzy";

            Console.WriteLine(Student.FirstName);
            Console.WriteLine(Student.LastName);

            Student2.FirstName = "Omar";
            Student2.LastName = "ALi";

            Console.WriteLine(Student2.FirstName);
            Console.WriteLine(Student2.LastName);

            Console.ReadKey();
        }
    }
}
