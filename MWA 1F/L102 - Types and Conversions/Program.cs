using System;
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
            int myNum = 6;

            int yourNum = (int) Math.Round(12.5, MidpointRounding.AwayFromZero);

            Console.WriteLine(yourNum);


            string name = "Matt";
            char c = name[0];

            Console.WriteLine(c);

            Console.WriteLine($"Num: {yourNum}");

            (yourNum).ToString();

            string letter = 'A'.ToString();

            int num = 'A';
            char l = (char) 60;


            char c2 = char.Parse("M");
            int num2 = int.Parse(Console.ReadLine());
            double d = double.Parse("12.6");
            Console.WriteLine(c2);

            bool b;

            if (name == "Matt")
            {
                b = true;
            } else
            {
                b = false;
            }

            b = (name == "Matt");

            Console.ReadKey();
        }
    }
}
