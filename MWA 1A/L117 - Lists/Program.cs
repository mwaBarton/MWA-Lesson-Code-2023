using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L117___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare list
            List<int> numbers;

            // Create list and associate it with my variable
            numbers = new List<int>();

            // Populate list
            numbers.Add(5);
            numbers.Add(-1);
            numbers.Add(1024);
            numbers.Add(20);

            numbers.Remove(-1);

            // Update elements
            numbers[0] = 10;

            // Print elements
            Console.WriteLine(numbers[0] + " " + numbers[1]);

            // Print length
            Console.WriteLine(numbers.Count);

            // Create new list
            //numbers = new List<int>();
            //Console.WriteLine(numbers.Count);

            // Loop through the list
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            foreach(int num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }
    }
}
