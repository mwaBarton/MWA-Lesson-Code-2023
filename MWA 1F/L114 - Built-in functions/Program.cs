using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L114___Built_in_functions
{
    internal class Program
    {
        static void FirstTask()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();

            Console.Write("Select an option (1 = Length, 2 = upper, 3 = lower) ");
            string option = Console.ReadLine();

            switch (option) {
                case "1":
                    Console.WriteLine(s.Length);
                    break;
                case "2":
                    Console.WriteLine(s.ToUpper());
                    break;
                case "3":
                    Console.WriteLine(s.ToLower());
                    break;

            }
        }


        static void Main(string[] args)
        {
            while(true) { 
                Console.Write("Enter a string: ");
                string userInput = Console.ReadLine();

                // Get a particular character
                char letter = userInput[userInput.Length - 1];
                Console.WriteLine(letter);

                // Get the length of the string
                int l = userInput.Length;
                Console.WriteLine(l);

                // lowercase and uppercase
                string upper = userInput.ToUpper();
                string lower = userInput.ToLower();
                Console.WriteLine($"Upper: {upper}, lower: {lower}");

                // Substring
                //Console.Write("How many characters to chop off the end? ");
                int num = 3;
                string sub = userInput.Substring(0, userInput.Length - num);
                Console.WriteLine(sub);

                // Find the index of a substring
                int index = userInput.IndexOf("ham");
                Console.WriteLine(index);

                // Comparing strings
                Console.Write("Enter another string: ");
                string userInput2 = Console.ReadLine();

                int result = string.Compare(userInput, userInput2);
                Console.WriteLine(result);

                if (string.Compare(userInput, userInput2) == -1)
                {
                    Console.WriteLine("first input is earlier than second input");
                } else
                {
                    Console.WriteLine("first input is later than second input");
                }

                // Accessing character codes
                char symbol = userInput[0];
                int symbolCode = (int)symbol;
                symbolCode++;
                char newSymbol = (char)symbolCode;
                Console.WriteLine(newSymbol);

                Console.WriteLine(((char)((int)userInput[0] + 1)).ToString() + userInput.Substring(1));

                Console.ReadKey();
            }
        }
    }
}
