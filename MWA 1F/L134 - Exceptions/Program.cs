using System;

namespace L134___Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = { 1, 2, 3, 4 };

            int index;
            Console.Write("Enter index: ");

            index = int.Parse(Console.ReadLine());

            try
            {
                myarray[index] = 10;

                Console.WriteLine($"Array at index {index} updated to 10.");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NAUGHTY!! no presents for you this year!");
                Console.ForegroundColor= ConsoleColor.Gray;
            }

            Console.ReadKey();
        }
    }
}
