using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L123___Functions
{
    internal class Program
    {
        static string SayAah(int angerLevel)
        {
            string result = "A";
            for (int i = 0; i < angerLevel; i++)
            {
                result += "a";
            }
            result += "h";

            if (angerLevel > 5)
            {
                result += "!";
            }

            return result;
        }

        static void Main(string[] args)
        {
            string myString = SayAah(5);

            Console.WriteLine(myString);
            Console.ReadKey();
        }
    }
}
