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

            //WhatCouldPossiblyGoWrong(10);

            //int total = 0;
            //for (int i = 0; i < 1000000; i++)
            //{
            //    total += (int)Math.Pow(i, 2);
            //    Console.WriteLine($"i: {i}, adding: {(int)Math.Pow(i, 2)}, total: {total}");
            //}
            //Console.WriteLine(total);


            int num;
            num = 5;


            int[] myArray;
            myArray = new int[6];

            myArray[0] = 1;
            myArray[1] = 1;
            myArray[2] = 2;
            myArray[3] = 3;
            myArray[4] = 5;
            myArray[5] = 8;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Enter element {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(myArray[0]);


            Console.ReadKey();
        }
    }
}
