using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L116___Debugging_and_Arrays
{
    internal class Program
    {
        static void DoIt()
        {
            Console.WriteLine("Just do it!");
        }

        static void Main(string[] args)
        {
            //DoIt();
            //int total = 0;
            //for (int i = 0; i < 1000000; i++)
            //{
            //    total += (int)Math.Pow(i, 2);
            //    Console.WriteLine($"i: {i}, adding: {(int)Math.Pow(i, 2)}, new total: {total}");
            //}
            //Console.WriteLine(total);


            int num;
            num = 5;


            int[] myArray;
            myArray = new int[6];

            myArray[0] = 1;

            num = myArray[5];
            Console.WriteLine(myArray[4] + 1);

            // Populating an array

            // 1. One index at a time
            myArray[0] = 1;
            myArray[1] = 1;
            myArray[2] = 2;
            myArray[3] = 3;
            myArray[4] = 5;
            myArray[5] = 8;

            // 2. Using a for loop
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Enter element {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            // 3. Auto-initialise
            string[] names = { "Adam", "Adam", "Adam", "Adam" };
            PrintArray(names);

            // Output array using a for loop
            PrintArray(myArray);

            Console.ReadKey();
        }

        static void PrintArray<T>(T[] a)
        {
            Console.Write("[");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                if (i < a.Length - 1) Console.Write(", ");
            }
            Console.Write("]");
        }
    }
}
