using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L114___built_in_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();

            // Length of the string
            int l = userInput.Length;
            Console.WriteLine(l);

            for (int i = 0; i < userInput.Length; i++) {
                Console.Write(userInput[i]);
            }

            // lowercase or uppercase
            string lower = userInput.ToLower();
            string upper = userInput.ToUpper();
            Console.WriteLine($"uppercase: {upper}, lowercase: {lower}");

            // Substring
            string sub = userInput.Substring(1, userInput.Length - 1);
            Console.WriteLine(sub);

            // Search for a substring
            int index = userInput.IndexOf("ham");
            Console.WriteLine(index);

            // Comparing strings
            Console.Write("Enter second string: ");
            string userInput2 = Console.ReadLine();

            if (userInput == userInput2)
            {
                Console.WriteLine("Strings are equal");
            } else if (string.Compare(userInput, userInput2) == -1)
            {
                Console.WriteLine("first string is earlier than second string");
            } else
            {
                Console.WriteLine("first string is later than second string");
            }

            // Dealing with character codes
            char letter = userInput[0];
            int charCode = (int)letter;
            charCode++;
            char newLetter = (char)charCode;
            Console.WriteLine(newLetter);


            // Shift the first character in string forward by 1
            Console.WriteLine(((char)((int)userInput[0] + 1)).ToString() + userInput.Substring(1));

            Console.ReadKey();
        }
    }
}
