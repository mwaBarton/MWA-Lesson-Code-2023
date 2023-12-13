using System;

namespace L134___Exceptions
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int[] myArray = { 1, 2, 3, 4 };

        //    int index;
        //    bool valid = false;

        //    while (!valid)
        //    {
        //        Console.Write("Enter index: ");

        //        try
        //        {
        //            index = int.Parse(Console.ReadLine());

        //            myArray[index] = 10;
        //            Console.WriteLine($"Array at index {index} updated to 10.");
        //            valid = true;
        //        }
        //        catch (IndexOutOfRangeException ex)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("NAUGHTY!! no presents for you this year!");
        //            Console.WriteLine(ex.GetType().Name);
        //            Console.WriteLine(ex.Message);
        //            Console.ForegroundColor = ConsoleColor.Gray;
        //        }
        //        catch (FormatException ex)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("You must enter an integer...");
        //            Console.ForegroundColor = ConsoleColor.Gray;
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine($"Unexpected error [{ex.GetType().Name}] occurred: {ex.Message}\n{ex.StackTrace}");
        //            Console.ForegroundColor = ConsoleColor.Gray;
        //        }
        //    }

        //    Console.ReadKey();
        //}

        static char gradeCalculator(int scorePercentage)
        {
            // Defensive Programming

            if (scorePercentage > 100 || scorePercentage < 0)
            {
                throw new ArgumentException("The score must be between 0 and 100.");
            }

            if (scorePercentage >= 80)
            {
                return 'A';
            }
            else if (scorePercentage >= 70)
            {
                return 'B';
            }
            else if (scorePercentage >= 60)
            {
                return 'C';
            }
            else if (scorePercentage >= 50)
            {
                return 'D';
            }
            else if (scorePercentage >= 0)
            {
                return 'U';
            }
            else
            {
                return 'G';
            }
        }

        static void Main(string[] args)
        {
            int score;

            bool valid = false;

            while (!valid)
            {
                Console.Write("What's your percentage: ");
                
                try
                {
                    score = int.Parse(Console.ReadLine());

                    Console.WriteLine("Your grade was " + gradeCalculator(score));
                    valid = true;
                }
                catch (ArgumentException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (FormatException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must enter an integer.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            Console.ReadKey();
        }

    }
}
