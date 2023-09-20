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
            string numBags;

            Console.Write("How many bags did you use: ");
            numBags = Console.ReadLine();

            switch (numBags)
            {
                case "None":
                    Console.WriteLine("You have used no bags. Well done");
                    break;
                default:
                    int bags = int.Parse(numBags);

                    switch (bags)
                    {
                        case 1:
                            Console.WriteLine("That's very efficient!");
                            break;
                        case 2:
                            Console.WriteLine("That's fine. This is a par 2 shopping centre.");
                            break;
                        case 3:
                            Console.WriteLine("You're using too many bags");
                            break;
                        default:
                            Console.WriteLine("WHAaaAATTTTTA!!!!!1");
                            break;
                    }

                    break;
            }
            Console.ReadKey();
        }
    }
}
