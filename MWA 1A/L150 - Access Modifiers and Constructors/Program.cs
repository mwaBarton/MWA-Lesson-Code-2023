using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L150___Access_Modifiers_and_Constructors
{
    internal class Car
    {
        private int horsePower;
        private string colour;

        public Car()
        {
            Console.WriteLine("Hello, I am a newly birthed car!");
        }

        public string GetColour()
        {
            return colour;
        }

        public void SetColour(string newColour)
        {
            if ((new string[] { "red", "blue", "white"}).Contains(newColour)) 
                colour = newColour;
            else
                Console.WriteLine("Not allowed.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.SetColour("red");

            Console.ReadKey();
        }
    }
}
