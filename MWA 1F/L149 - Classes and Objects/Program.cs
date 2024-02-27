using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L149___Classes_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck jimmy = new Duck();

            jimmy.colour = "red";
            jimmy.isAlive = true;
            jimmy.mass = 5;
            jimmy.secondsUntilExpiry = 6;

            while (jimmy.isAlive)
            {
                Console.WriteLine(jimmy.Quack());
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
