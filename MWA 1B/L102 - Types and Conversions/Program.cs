using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L102___Types_and_Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 6;

            double d = num * 2;

            // Banker's rounding
            int num2 = (int) Math.Round(num * 2.1);

            Console.WriteLine(num2);

            Console.WriteLine((int) (12.5 + 0.5));


            // Let's talk about strings...

            string name = "Matt";

            char letter = name[0];

            int x = letter;

            Console.WriteLine(((char) (int) Math.Round(x+1.5)).ToString());

            bool b = bool.Parse(Console.ReadLine());
            Console.WriteLine(b);

            b = true;
            b = false;

            if (name == "Matt")
            {
                b = true;
            } else
            {
                b = false;
            }

            b = (name == "Matt");
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
