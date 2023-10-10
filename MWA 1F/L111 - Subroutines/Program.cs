using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L111___Subroutines
{
    internal class Program
    {
        static string name; // A global variable

        static void SayGoodBye()
        {
            string x = "Hello"; // A local variable
            Console.WriteLine($"gOODBYE {name}");
        }

        static void SayHello()
        {
            Console.WriteLine("What's your name?");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            SayGoodBye();
        }

        static void Main(string[] args)
        {
            SayHello();

            Console.WriteLine("does soemthing");

            SayHello();

            Console.ReadKey();
        }
    }
}
