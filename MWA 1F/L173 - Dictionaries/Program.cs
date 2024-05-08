using System;
using System.Collections.Generic;

namespace L173___Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> faveNums = new Dictionary<string, int>();

            faveNums.Add("Oscar", 3);
            faveNums.Add("Areeb", 7);
            faveNums.Add("Quinn", 9);
            faveNums.Add("Dan", 6);

            Console.WriteLine(faveNums.Count);

            faveNums.Remove("Dan");

            faveNums["Areeb"]++;

            Console.WriteLine(faveNums["Areeb"]);

            foreach (string name in faveNums.Keys)
            {
                Console.WriteLine($"{name}'s favourite number is {faveNums[name]}");
            }

            Task1();

            Console.ReadKey();
        }

        static void Task1()
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();

            string input = Console.ReadLine();

            foreach (string word in input.Split(' '))
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts.Add(word, 1);
                }
            }

            foreach (string word in counts.Keys)
            {
                Console.WriteLine($"{word} : {counts[word]}");
            }
        }
    }
}
