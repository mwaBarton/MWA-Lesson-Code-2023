using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L117___Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] a = new int[10];

            // Declaring a list variable, which is a reference to a list object
            List<int> numbers;

            // Create a new list and store the reference in numbers
            numbers = new List<int>();

            // Populate the list
            numbers.Add(5);
            numbers.Add(-10);
            numbers.Add(500);
            numbers.Remove(-10);
            numbers.Add(1001);
            numbers.RemoveAt(0);

            // Get length of list
            Console.WriteLine(numbers.Count);

            // Access elements
            numbers[0] = 50;
            Console.WriteLine(numbers[0] + " " + numbers[1]);

            numbers = new List<int>();
            Console.WriteLine(numbers.Count);

            Console.ReadKey();
        }
    }
}
