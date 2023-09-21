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
            // Rectangle of stars
            int starsPerRow, numRows;

            Console.Write("How many rows: ");
            numRows = int.Parse(Console.ReadLine());
            Console.Write("How many stars per row: ");
            starsPerRow = int.Parse(Console.ReadLine());

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < starsPerRow; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
