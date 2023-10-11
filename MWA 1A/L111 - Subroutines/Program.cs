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
            Console.Write("Choose a colour: ");
            string input = Console.ReadLine();
            InitialiseConsoleColour(input, true);

            // Call the subroutine
            SayHello();
            Console.WriteLine("Something else");
            SayHello();

            InitialiseConsoleColour("green", false);

            Console.ReadKey();
        }
        // Parameter (aka Input/Argument)
        static void InitialiseConsoleColour(string colour, bool message)
        {
            switch (colour.ToLower())
            {
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "magenta":
                case "pink":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "blue":
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
            }

            if (message)
            {
                Console.WriteLine($"Console colour was changed to '{colour}'");
            }
        }
    }
}
