using System;

namespace L134___Exceptions_but_it_should_work_this_time
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int[] myarray = { 1, 2, 3, 4 };

        //    int index;

        //    bool valid = false;

        //    while (!valid)
        //    {
        //        Console.Write("Enter index: ");


        //        try
        //        {
        //            index = int.Parse(Console.ReadLine());

        //            myarray[index] = 10;

        //            Console.WriteLine($"Array at index {index} updated to 10.");

        //            valid = true;
        //        }
        //        catch (IndexOutOfRangeException ex)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("NAUGHTY!! no presents for you this year!");
        //            Console.WriteLine(ex.Message);
        //            Console.WriteLine(ex.GetType().Name);
        //            Console.WriteLine(ex.StackTrace);
        //            Console.ForegroundColor = ConsoleColor.Gray;
        //        }
        //        catch (FormatException ex)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("integer or die");
        //            Console.WriteLine(ex.Message);
        //            Console.ForegroundColor = ConsoleColor.Gray;
        //        }
        //    }



        //    Console.ReadKey();
        //}


        static char gradeCalculator(int scorePercentage)
        {
            // Defensive programming
            if (scorePercentage < 0 || scorePercentage > 100)
            {
                throw new ArgumentException("Score percentage must be between 0 and 100.");
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
                return '#';
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

                    if (score < 0 || score > 100)
                    {
                        throw new ArgumentException();
                    }

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
                    Console.WriteLine("Enter an integer plz");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            Console.ReadKey();
        }


    }
}
