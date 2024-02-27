using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L150___Access_Modifiers_and_Constructors
{
    internal class Fruit
    {
        private int numberOfSeeds;

        public Fruit(int inputSeeds)
        {
            if (inputSeeds < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(inputSeeds));
            }
            numberOfSeeds = inputSeeds;
        }

        public Fruit()
        {
            numberOfSeeds = 0;
            Console.WriteLine("Default number of seeds used: " + numberOfSeeds);
        }

        public int GetNumberOfSeeds() {  return numberOfSeeds; }

        public void Consume()
        {
            if (numberOfSeeds > 0)
            {
                Console.WriteLine("Yum yum in my tum.");
            } else
            {
                Console.WriteLine("Not seedy enough for me.");
            }
            numberOfSeeds = 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many seeds?");
            Fruit banana = new Fruit(int.Parse(Console.ReadLine()));
            Fruit lemon = new Fruit();

            
            Console.WriteLine(banana.GetNumberOfSeeds());
            banana.Consume();
            Console.WriteLine(banana.GetNumberOfSeeds());

            Console.ReadKey();
        }
    }
}
