using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L149___Classes_and_Objects
{
    internal class Dinosaur
    {
        public bool isAlive;
        public double runningSpeed;
        public double mass;
        public string name;

        public void Eat()
        {
            if (isAlive)
            {
                Console.Write("Yumm");
                for (int i = 0; i < mass; i++)
                {
                    Console.Write("m");
                }
                Console.WriteLine("y");
            } else
            {
                Console.WriteLine("Nothing happens...");
            }
        }
    }
}
