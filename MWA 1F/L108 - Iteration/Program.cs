using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L108___Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definite iteration
            // Number of loops known before first loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Happy Septemberfest!");
            }

            //// Indefinite (condition-controlled)
            int x = 5;
            while (x > 0)
            {
                Console.WriteLine("Happy Septemberfest! Are you scared?");
                if (Console.ReadLine() == "boo")
                {
                    x--;
                }
                x--;
            }

            //// Infinite loop
            while (1 + 1 == 2)
            {
                Console.Write("X");

                break;
            }

            // Example
            bool goAgain = false;
            do
            {
                // Some stuff...
                Console.WriteLine("Hello");
                // More stuff...

                Console.Write("Would you like to go again? (Press Y)");
                goAgain = (Console.ReadKey(true).Key == ConsoleKey.Y);
                Console.WriteLine();
            } while (goAgain);

            Console.WriteLine();
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
    }
}
