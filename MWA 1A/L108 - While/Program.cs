using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L108___While
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool goAgain = false;
            do
            {
                int x = 0;
                int total = 0;
                while (x != -1)
                {
                    total += x;
                    Console.Write("Enter a number: ");
                    x = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Total: {total}");

                // Ask the user if they want to go again
                Console.WriteLine();
                Console.Write("Would you like to go again (y/n)?");

                ConsoleKeyInfo info = Console.ReadKey();



                if (info.Key == ConsoleKey.Y)
                {
                    goAgain = true;
                } else if (info.Key == ConsoleKey.N)
                {
                    goAgain = false;
                }
            } while (goAgain);

            Console.ReadKey();
        }
    }
}
