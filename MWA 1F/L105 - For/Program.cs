using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L105___For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 5; i > -15; i-=2)
            //{
            //    Console.WriteLine(i);
            //}

            // Extension: Without running this code, what does it print?
            for (int i=0, y=5; i < y; i+=2, y++, Console.WriteLine(i+y))
            {
                Console.WriteLine(i * y);
            }


            Console.ReadKey();
        }
    }
}
