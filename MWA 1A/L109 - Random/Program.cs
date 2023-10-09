using System;

namespace L109___Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random prng = new Random();

            double prob = 0.6;

            if (prng.NextDouble() < 1 - prob)
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
