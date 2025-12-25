using System;

namespace StringsOverview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S1 = "Abdelrhman Fawzy";

            Console.WriteLine(S1.Length);

            //this will take 5 characters staring position 2 
            Console.WriteLine(S1.Substring(2,5));
            Console.WriteLine(S1.ToLower());
            Console.WriteLine(S1.ToUpper());
            Console.WriteLine(S1[2]);
            Console.WriteLine(S1.Insert(3,"KKKK"));
            Console.WriteLine(S1.Replace("m","*"));
            Console.WriteLine(S1.IndexOf("m"));
            Console.WriteLine(S1.Contains("m"));
            Console.WriteLine(S1.Contains("x"));
            Console.WriteLine(S1.LastIndexOf("m"));

            string S2 = "Ali,Ahmed,Khalid";

            string[] NameList = S2.Split(',');
            Console.WriteLine(NameList[0]);
            Console.WriteLine(NameList[1]);
            Console.WriteLine(NameList[2]);

            string S3 = "    Abdel-rhman    ";

            Console.WriteLine(S3.Trim());
            Console.WriteLine(S3.TrimStart());
            Console.WriteLine(S3.TrimEnd());

            Console.ReadKey();

        }
    }
}
