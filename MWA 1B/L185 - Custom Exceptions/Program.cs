using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L185___Custom_Exceptions
{
    public class InsufficientPizzaToppingsException : Exception
    {
        private List<string> theToppings;

        public InsufficientPizzaToppingsException(List<string> toppings) : base($"Not enough pizza toppings m8. U R missing {12 - toppings.Count} toppings.")
        {
            theToppings = toppings;
        }

        public List<string> GetNumberOfToppings() => theToppings;

        public string GetMostCommonTopping() => theToppings.GroupBy(t => t).OrderByDescending(tg => tg.Count()).First().Key;
    }

    internal class Program
    {
        static List<string> GetToppingsFromUser()
        {
            List<string> toppings = new List<string>();

            string input = "";

            do
            {
                Console.Write("Enter next topping, or just hit Enter to stop: ");
                input = Console.ReadLine();
                if (input != "") toppings.Add(input);
            } while (input != "");
            
            if (toppings.Count < 12)
            {
                throw new InsufficientPizzaToppingsException(toppings);
            }

            return toppings;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hellow, and welcome to my very strict pizzeria. You will begin by entering your toppings. If Adam approves, you will get your pizza");
            List<string> toppings;
            try
            {
                toppings = GetToppingsFromUser();

                Console.WriteLine("You have a pizza. Adam is happy enough. well done gg.");
            }
            catch (InsufficientPizzaToppingsException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + ex.Message + "\nAdam doesn't approve. You didn't use enough of " + ex.GetMostCommonTopping() + "\n");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            

            Console.ReadKey();
        }
    }
}
