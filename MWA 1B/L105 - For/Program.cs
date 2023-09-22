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
            string s = "";
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    s += "*";
                }
                s += "\n";
            }

            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
