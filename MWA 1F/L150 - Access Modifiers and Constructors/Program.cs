using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L150___Access_Modifiers_and_Constructors
{
    class Person
    {
        private int age;

        public Person()
        {
            Console.WriteLine($"I am a newly birthed person. I joined the server at level {age}. Yay.");
        }

        public Person(int inputAge)
        {
            age = inputAge;
        }

        public int GetAge()
        {
            return age;
        }

        public void HaveBirthday()
        {
            age++;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person matt = new Person(5);

            Console.WriteLine(matt.GetAge());
            for (int i = 0; i < 12; i++)
            {
                matt.HaveBirthday();
            }
            Console.WriteLine(matt.GetAge());

            Console.ReadKey();
        }
    }
}
