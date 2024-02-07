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
            Dinosaur jimmy = new Dinosaur();

            jimmy.isAlive = true;
            jimmy.runningSpeed = 100;
            jimmy.mass = 100;
            jimmy.name = "Pterodactyl";

            jimmy.Eat();

            Console.ReadKey();

            jimmy.isAlive = false;
            jimmy.Eat();

            Console.ReadKey();
        }
    }
}
