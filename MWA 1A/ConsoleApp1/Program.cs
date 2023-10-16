using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void FirstTask()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            Console.WriteLine("Choose an option: 1 - length, 2 - upper, 3 - lower");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.WriteLine(word.Length);
                    break;
                case 2:
                    Console.WriteLine(word.ToUpper());
                    break;
                case 3:
                    Console.WriteLine(word.ToLower());
                    break;
            }
        }

        static void SecondTask() {
            Console.WriteLine("Enter your first name");
            string firstName = Console.ReadLine();

            
            string password = firstName.ToUpper()[0].ToString();
        }

        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string userInput = Console.ReadLine();

            // Length
            int l = userInput.Length;
            Console.WriteLine(l);
            Console.WriteLine(userInput[l-1]); // Last character

            // Upper and lower case
            Console.WriteLine($"In uppercase: {userInput.ToUpper()}");
            Console.WriteLine($"In lowercase: {userInput.ToLower()}");

            // Substring
            string sub = userInput.Substring(0, userInput.Length - 1);
            Console.WriteLine(sub);

            // Index of substring
            int index = userInput.IndexOf("ham");
            Console.WriteLine(index);
            if (index != -1)
            {
                Console.WriteLine(userInput.Substring(index, 3));
            }

            // Contains
            bool search = userInput.Contains("ham");
            Console.WriteLine(search);

            // Comparing strings
            Console.Write("Enter another string: ");
            string otherInput = Console.ReadLine();
            int comparison = string.Compare(userInput, otherInput);
            Console.WriteLine(comparison);

            // Test for equality
            if (userInput == otherInput)
            {
                Console.WriteLine("Strings are equal");
            }
            else if (string.Compare(userInput, otherInput) < 0) {
                Console.WriteLine("Second string is later in the order than first string");
            }
            else
            {
                Console.WriteLine("Second string is earlier in the order than first string");
            }

            // Converting char to int
            char letter = userInput[0];
            Console.WriteLine(letter);

            int letterVal = (int)letter;
            Console.WriteLine(letterVal);

            Console.WriteLine(((char)((int)userInput[0] + 1)).ToString() + userInput.Substring(1));

            Console.ReadKey();
        }
    }
}
