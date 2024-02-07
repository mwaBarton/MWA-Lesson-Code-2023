using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L148___Classes_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drink myDrink = new Drink();

            myDrink.viscosity = 50;
            myDrink.isAlcoholic = true;
            myDrink.type = "Wkd";

            myDrink.DrinkIt();

            Console.ReadKey();
        }
    }
}
