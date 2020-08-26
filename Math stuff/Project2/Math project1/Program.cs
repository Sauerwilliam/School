using System;
using System.Security.Cryptography.X509Certificates;

namespace Math_project1
{
    class Program
    {
        

        static void Main(string[] args)
        {

            string numbers = Console.ReadLine();

            string[] words = numbers.Split(' ');

            
            foreach (var word in words)
            {
                int x = word.IndexOf("x");


                System.Console.WriteLine("X = " + x);
                if (x == -1)
                {
                    System.Console.WriteLine($"{word}");

                }

                if (x >= 1)
                {


                    int substringsub = word.Length - 1;
                    int substringsubs = word.Length;
                    string sub = word.Substring(0, x);
                    string subs = word.Substring(x);


                    Console.WriteLine(sub);
                    Console.WriteLine(subs);




                }

            }

        }
    }
}
