using System;

namespace L134___Exceptions
{
    internal class Program
    {
        static char GradeCalculator(int scorePercentage)
        {
            // Defensive programming
            if (scorePercentage < 0 || scorePercentage > 100)
            {
                throw new ArgumentException("Score must be between 0 and 100%.");
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

            return '!';
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

                    if (score < 0 || score > 100)
                    {
                        throw new ArgumentException("Score must be between 0 and 100%.");
                    }

                    Console.WriteLine("Your grade was " + GradeCalculator(score));
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

        //static void Main(string[] args)
        //{
        //    int[] myarray = { 0, 1, 2, 3 };

        //    bool valid = false;

        //    while (!valid)
        //    {
        //        Console.Write("Enter index: ");
        //        try
        //        {
        //            int index = int.Parse(Console.ReadLine());
        //            myarray[index] = 10;
        //            Console.WriteLine($"Array at {index} updated to 10.");
        //            valid = true;
        //        }
        //        catch (IndexOutOfRangeException ex)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("NAUGHTY!! No presents this year.");
        //            Console.WriteLine(ex.Message);
        //            Console.ForegroundColor = ConsoleColor.Gray;
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine($"An unexpected error occurred [{ex.GetType().Name}]: {ex.Message}");
        //            Console.ForegroundColor = ConsoleColor.Gray;
        //        }
        //    }



        //    Console.ReadKey();
        //}

        //static int keepCounting(int n)
        //{
        //    try
        //    {
        //        return n + keepCounting(n + 1);
        //    }
        //    catch (Exception)
        //    {
        //        return 0;
        //    }
        //}

    }
}
