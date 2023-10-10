using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L111___Subroutines
{
    internal class Program
    {
        static string name; // global variable

        static void SayGoodbye()
        {
            Console.WriteLine($"gOODBYE {name}");
        }

        static void SayHello()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            SayGoodbye();
        }

        static void Main(string[] args)
        {
            string favColour = "Magenta";

            Console.ForegroundColor = (ConsoleColor) Enum.Parse(typeof(ConsoleColor), favColour);


            SayHello();

            Console.WriteLine("does soemthing");

            SayHello();

            Console.ReadKey();
        }
    }
}
