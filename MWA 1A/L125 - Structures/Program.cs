using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L125___Structures
{
    internal class Program
    {
        struct MenuItem
        {
            public string name;
            public double price;
            public bool isSpicy;
        }

        static void printMenu(MenuItem[] menu)
        {
            foreach (MenuItem item in menu)
            {
                Console.WriteLine($"{item.name} costs £{item.price}");
            }
        }

        static void Main(string[] args)
        {
            MenuItem item1;
            item1.name = "kebab";
            item1.price = 7.99;
            item1.isSpicy = true;

            MenuItem[] menu = new MenuItem[3];
            menu[0] = item1;
            menu[1].name = "Single piece of chicken";
            menu[1].price = 60.99;
            menu[1].isSpicy = false;
            menu[2].name = "banana";
            menu[2].price = 0.106;
            menu[2].isSpicy = true;

            printMenu(menu);

            Console.ReadKey();
        }
    }
}
