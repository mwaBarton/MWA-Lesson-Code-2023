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
            string name;
            int age;

            Console.Write("Enter you name: ");
            name = Console.ReadLine();

            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is " + age);

            Console.ReadKey();

        }
    }
}
