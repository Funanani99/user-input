using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name =Console.ReadLine();
            Console.WriteLine("Enter your born year");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            int age = 2023 - birthYear;
            Console.WriteLine("Hello! " + name + "," + " you are " + age + " years old.");
            Console.ReadLine();
        }
    }
}
