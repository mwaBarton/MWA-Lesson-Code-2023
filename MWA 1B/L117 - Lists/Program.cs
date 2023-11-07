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
            // Declared a variable to store a reference to a list object
            List<int> numbers;

            // Creating a new list and storing its reference in the variable
            numbers = new List<int>();

            // Populate the list
            numbers.Add(5);
            numbers.Add(-10);
            numbers.Add(500);
            numbers.Add(1001);
            numbers.Remove(-10);
            numbers.RemoveAt(0);

            // Access particular list elements
            numbers[0] = 50;
            Console.WriteLine(numbers[0] + " " + numbers[1]);

            // Find the length of the list
            Console.WriteLine(numbers.Count);

            numbers = new List<int>();
            Console.WriteLine(numbers.Count);
        }
    }
}
