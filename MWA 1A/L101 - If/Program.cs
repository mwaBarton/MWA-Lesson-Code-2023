using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L101___If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            if (name == "Matt" || name == "Bob")
            {
                Console.WriteLine($"Hello {name}");
            } else
            {
                Console.WriteLine("I don't know you!");
            }

            if (name == "Matt")
            {
                Console.WriteLine($"Hello {name}");
            }
            else if (name == "Bob")
            {
                Console.WriteLine("I don't know you!");
            }

            Console.ReadKey();
        }
    }
}
