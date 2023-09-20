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
            string faveCartoon;
            Console.Write("Enter your favourite cartoon: ");
            faveCartoon = Console.ReadLine();

            switch (faveCartoon)
            {
                case "Paw Patrol":
                    Console.WriteLine("Dan disapproves...");
                    break;
                case "Mickey Mouse":
                    Console.WriteLine("Good choice!");
                    break;
                case "Adventure Time":
                    Console.WriteLine("YEASSHHHHH");
                    break;
                case "Scooby Doo":
                    Console.Write("How many times have you watched scooby doo in the last week: ");
                    int numWatches = int.Parse(Console.ReadLine());

                    switch (numWatches)
                    {
                        case 0:
                            Console.WriteLine("You're not a real fan");
                            break;
                        case 1:
                        case 2:
                            Console.WriteLine("1 or 2 times kk");
                            break;
                        default:
                            Console.WriteLine("Wow that's a lot!");
                            break;
                    }

                    break;
            }

            Console.ReadKey();
        }
    }
}
