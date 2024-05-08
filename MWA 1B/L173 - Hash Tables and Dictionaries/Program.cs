using System;
using System.Collections.Generic;

namespace L173___Hash_Tables_and_Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> pizzaToppingPrices = new Dictionary<string, double>();

            pizzaToppingPrices.Add("Pepperoni", 25);
            pizzaToppingPrices.Add("Pineapple", 27);
            pizzaToppingPrices.Add("Peppers", 42);

            pizzaToppingPrices["Peppers"] = 5.99;

            Console.WriteLine(pizzaToppingPrices["Pineapple"]);

            pizzaToppingPrices.Remove("Pepperoni");

            foreach (string topping in pizzaToppingPrices.Keys)
            {
                Console.WriteLine($"{topping} has price £{pizzaToppingPrices[topping]}");
            }

            Console.ReadKey();
        }
    }
}
