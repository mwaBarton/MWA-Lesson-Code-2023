using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L123___Functions
{
    internal class Program
    {
        static string PizzaRandomiser(List<string> toppings)
        {
            Console.WriteLine("boo");

            switch (toppings.Count)
            {
                case 0:
                    return "the null shape";
                case 1:
                    return "circle";
                case 2:
                    return "square";
                default:
                    return "triangle";
            }

            
        }

        static void Main(string[] args)
        {
            List<string> myToppings = new List<string>() { "mozzarella", "anchovies", "pineapple" };

            Console.WriteLine(PizzaRandomiser(myToppings));
            Console.ReadKey();
        }
    }
}
