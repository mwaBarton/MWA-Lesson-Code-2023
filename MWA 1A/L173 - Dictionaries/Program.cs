using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L173___Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> faveNums = new Dictionary<string, int>();

            // Add new paid to the dictionary
            faveNums.Add("Omar", 7);
            faveNums.Add("Harry", 7);
            faveNums.Add("Josh", 7);

            while (true) {
                // Access value for a given key
                Console.Write("Enter name: ");
                string input = Console.ReadLine();

                if (faveNums.ContainsKey(input))
                {

                    Console.WriteLine($"{input}'s favourite number is {faveNums[input]}");
                }
                else
                {
                    Console.WriteLine($"We don't know {input}'s favourite number. You can tell me now!");

                    int num = int.Parse(Console.ReadLine());

                    faveNums.Add(input, num);
                }

                foreach (string name in faveNums.Keys)
                {
                    Console.WriteLine($"{name}'s favourite number is {faveNums[name]}");
                }
            }
            

            Console.ReadKey();
        }
    }
}
