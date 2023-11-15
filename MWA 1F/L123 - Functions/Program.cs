using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L123___Functions
{
    internal class Program
    {
        static float Add3POINtFive(float number)
        {
            Console.WriteLine("Boo");
            return number + 3.5f;
            Console.WriteLine("Hi");
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add3POINtFive(10f));
            Console.ReadKey();
        }
    }
}
