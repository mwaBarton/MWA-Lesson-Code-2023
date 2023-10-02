using System;

namespace L109___Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random prng = new Random();

            if (prng.NextDouble() < 0.45)
            {
                Console.WriteLine("It happened");
            }

            while (true)
            {
                int num = prng.Next(1, 7); // 1 <= num < 7
                Console.WriteLine(num);

                Console.ReadKey();
            }
        }
    }
}
