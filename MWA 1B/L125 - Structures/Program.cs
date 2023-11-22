using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L125___Structures
{
    internal class Program
    {
        struct Animal
        {
            public double volume;
            public string generalColourSortOf;
            public double speed;
        }

        static void PrintZoo(Animal[] animals)
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"I have a {animal.generalColourSortOf} animal. " +
                    $"It is {animal.volume}m^3 and moves at {animal.speed}ms^-1");
            }
        }

        static void PrintAnimal(Animal a)
        {

        }


        static void PrintInt(int x)
        {

        }

        static void Main(string[] args)
        {
            Animal a1;
            a1.volume = 27.6;
            a1.generalColourSortOf = "Grey";
            a1.speed = 100;

            Animal a2 = new Animal();

            PrintAnimal(a2);

            Animal[] zoo = new Animal[3];
            zoo[0] = a1;
            zoo[1].volume = 4;
            zoo[1].generalColourSortOf = "White";
            zoo[1].speed = -5.6;
            zoo[2].volume = 5000;
            zoo[2].generalColourSortOf = "Rainbow";
            zoo[2].speed = 0.0005;

            PrintZoo(zoo);
            Console.ReadKey();
        }
    }
}
