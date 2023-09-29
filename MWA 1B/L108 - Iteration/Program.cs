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
            // Definite loop
            // Number of iterations explicit at the start
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //// Indefinite (conditional) loop
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine(x);
                x++;
            }

            // Example
            bool goAgain = false;
            do
            {
                // Do some stuff
                Console.WriteLine("Happy Friday!");

                // Ask the user if they want to go again
                Console.WriteLine("\nAgain? (Press Y)");
                goAgain = (Console.ReadKey(true).Key == ConsoleKey.Y);
            } while (goAgain);

            // Infinite loop
            int num = 0;
            while (true)
            {
                switch (num)
                {
                    case 0: Console.BackgroundColor = ConsoleColor.Red; break;
                    case 1: Console.BackgroundColor = ConsoleColor.Green; break;
                    case 2: Console.BackgroundColor = ConsoleColor.Magenta; break;
                }

                Console.Write("X");

                num++;
                if (num == 3)
                {
                    num = 0;
                    continue;
                }
            }

            Console.ReadKey(true);
        }
    }
}
