using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L116___Debugging_and_Arrays
{
    internal class Program
    {
        static void WhatCouldPossiblyGoWrong(int x)
        {
            WhatCouldPossiblyGoWrong(x - 1);
        }


        static void Main(string[] args)
        {
            int num;
            num = 6;

            int[] myArray;
            myArray = new int[7];

            // One index at a time
            myArray[0] = 1;
            myArray[1] = 1;
            myArray[2] = 2;
            myArray[3] = 3;
            myArray[4] = 5;
            myArray[5] = 8;
            myArray[6] = 13;

            // Using a for loop
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Enter number {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            // auto-initialise
            string[] names = { "Matt", "Alex", "Kacper", "Numaya", "Amy" };

            Console.WriteLine(myArray[0]);

            Console.ReadKey();
        }
    }
}
