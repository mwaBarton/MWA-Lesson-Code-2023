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
            string myColour = "pink";
            SetConsoleColour(myColour, true);

            SayHello();

            Console.WriteLine("does soemthing");

            SetConsoleColour("green", false);

            SayHello();

            Console.ReadKey();
        }

        static void SetConsoleColour(string colour, bool message)
        {
            switch (colour.ToLower())
            {
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "magenta":
                case "pink":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
            }

            if (message)
            {
                Console.WriteLine($"Console colour was updated to {colour}");
            }

            //Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colour);
        }
    }
}
