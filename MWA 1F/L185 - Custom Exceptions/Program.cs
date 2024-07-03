using System;

namespace L185___Custom_Exceptions
{
    public enum CauseOfBadThings
    {
        Fleas,
        Zombies,
        Famine,
        Pestilence,
        Volcano,
        Meteor,
        Apathy,
        War,
        Custard,
        TooMuchPineappleOnPizzas
    }

    public class WorldIsEndingException : Exception
    {
        private CauseOfBadThings cause;

        public WorldIsEndingException(CauseOfBadThings cause) : base("AAAAAAAAAAAAAHHHHHHHHHHHHHHHHH HHHHHHHHHHHHHHHHH AHHHHHHHHHH!!!!!!!1")
        {
            this.cause = cause;
        }

        public CauseOfBadThings GetCause() => cause;
    }

    internal class Program
    {
        static void GoAboutYourDailyLife()
        {
            Random rnd = new Random();

            int numOfDays = 0;
            while (true)
            {
                Console.WriteLine($"You woke up on day {numOfDays}.");
                if (rnd.Next(100) < 1)
                {
                    CauseOfBadThings whatHappenedToday = (CauseOfBadThings)rnd.Next(11);

                    throw new WorldIsEndingException(whatHappenedToday);
                }
                Console.WriteLine("Another day, another dollar...");

                Console.WriteLine("You went to bed");
                numOfDays++;
                System.Threading.Thread.Sleep(10);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                GoAboutYourDailyLife();
            }
            catch (WorldIsEndingException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(Enum.GetName(ex.GetCause().GetType(), ex.GetCause())); // Converts enum to string
                Console.WriteLine(" happened.");
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.ReadKey();
        }
    }
}
