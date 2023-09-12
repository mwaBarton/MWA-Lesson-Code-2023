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

            name = Console.ReadLine();

            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello " + name);

            Console.ReadKey();

        }
    }
}
