using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L111___Subroutines
{
    internal class Program
    {
        // Global Variable
        static string name;

        static void SayGoodbye()
        {
            Console.WriteLine($"Bye {name}");
        }

        static void SayHello()
        {
            Console.Write("What's your name? ");
            name = Console.ReadLine(); // Local variable
            Console.WriteLine($"Hello {name}!");
            SayGoodbye();
            Console.WriteLine("Whatever");
        }

        static void Main(string[] args)
        {
            // Call the subroutine
            SayHello();

            Console.WriteLine("Something else");

            SayHello();

            Console.ReadKey();
        }
    }
}
