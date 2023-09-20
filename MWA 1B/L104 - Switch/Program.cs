using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L104___Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pizzaTopping;
            Console.Write("Enter your topping: ");
            pizzaTopping = Console.ReadLine();

            switch (pizzaTopping)
            {
                case "pineapple":
                    Console.WriteLine("Controversial!!");
                    break;
                case "cheese":
                    Console.WriteLine("That one goes without saying!");
                    break;
                case "peppers":
                    Console.Write("What kind of pepper? (j)alapenos or (s)weet: ");
                    char pepType = Console.ReadKey().KeyChar;

                    switch (pepType)
                    {
                        case 'j':
                            Console.WriteLine("\nSpicy!!");
                            break;
                        case 's':
                            Console.WriteLine("\nkk");
                            break;
                        default:
                            Console.WriteLine("\nLearn to follow instructions, you idiot!");
                            break;
                    }

                    break;
            }

            Console.ReadKey();
        }
    }
}
