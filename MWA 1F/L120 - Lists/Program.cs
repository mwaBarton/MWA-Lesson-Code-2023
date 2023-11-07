using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L120___Lists
{
    internal class Program
    {
        static void printList(List<string> list)
        {
            Console.Write("[");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count - 1) Console.Write(", ");
            }
            Console.WriteLine("]");
        }

        static void SplitStringIntoList(string str)
        {
            printList(str.Split(' ').ToList());
        }

        static void Main(string[] args)
        {
            List<string> shopping = new List<string>() { "Eggs", "Milk", "Flour" };
            printList(shopping);

            // 4. Split string into list
            Console.Write("Enter a string with spaces in: ");
            SplitStringIntoList(Console.ReadLine());

            // 3. Remove duplicates
            List<string> names = new List<string>();

            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Write("Enter a name, or 'done' to stop: ");
                string name = Console.ReadLine();

                if (name == "done") keepGoing = false;
                else if (!names.Contains(name)) names.Add(name);
            }

            Console.WriteLine($"There are {names.Count} unique names.");
            printList(names);


            Console.ReadKey();
        }
    }
}
