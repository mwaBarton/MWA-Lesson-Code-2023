using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L100___Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            int age;
            Console.Write("What is your age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine(age);


            Console.WriteLine("Hello " + name);
            Console.WriteLine("Goodbye, world!");
            Console.ReadKey();
        }
    }
}
