using System;
using System.Collections.Generic;

namespace L155___Polymorphism
{

    public class Animal
    {
        public  void Talk()
        {
            Console.WriteLine("*makes noise*");
        }
    }
    public class Dinosaur : Animal
    {
        public  void Talk()
        {
            Console.WriteLine("rah");
        }
    }
    public class Ferret : Animal
    {
        public  void Talk()
        {
            Console.WriteLine("shquheuahkh");
        }
    }

    internal class Program
    {


        static void Main(string[] args)
        {

            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal());
            animals.Add(new Dinosaur());
            animals.Add(new Ferret());

            foreach (Animal animal in animals)
            {
                animal.Talk();
            }
            Console.ReadKey();
        }
    }
}
