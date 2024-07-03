using System;

namespace L185___Exceptions_2
{
    public class UnexpectedFourException : Exception
    {
        public string offendingUsername;

        public UnexpectedFourException(string offendingUsername) : base($"Oh dear, another four appeared!!! It was {offendingUsername}'s fault")
        {
            this.offendingUsername = offendingUsername;
        }
    }

    internal class Program
    {
        static int GetNumFromUser(string user)
        {
            Console.Write("Enter a number other than 4: ");
            int result = int.Parse(Console.ReadLine());

            //if (result == 4)
            //{
            //    throw new UnexpectedFourException(user);
            //}

            return result;
        }

        static void Main(string[] args)
        {
            string username;

            Console.WriteLine("Hello, what is your name? ");
            username = Console.ReadLine();

            while (true)
            {
                try
                {
                    int x = GetNumFromUser(username);

                    if (x == 4)
                    {
                        throw new UnexpectedFourException(username);
                    }
                }
                catch (UnexpectedFourException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n" + e.Message + "\n" + e.offendingUsername + " didn't follow the rules!\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nYou must enter a number. Try again!\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
    }
}
