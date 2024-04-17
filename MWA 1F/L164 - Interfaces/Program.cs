using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L164___Interfaces
{
    interface IConsequence
    {
        string GetDescription();
        int GetDuration();
    }

    class PrisonTime : IConsequence
    {
        private int duration;
        public PrisonTime(int duration)
        {
            this.duration = duration;
        }

        public string GetDescription()
        {
            return "Prison time for " + duration + " days.";
        }
        public int GetDuration()
        {
            return duration;
        }
    }

    class Heat : IConsequence
    {
        private int duration;
        public Heat(int duration)
        {
            this.duration = duration;
        }

        public string GetDescription()
        {
            return "Heat for " + duration + " days.";
        }
        public int GetDuration()
        {
            return duration;
        }
    }

    interface ICrime
    {
        int GetSeverity();
        List<IConsequence> Commit();
    }

    class Arson : ICrime
    {
        public List<IConsequence> Commit()
        {
            Console.WriteLine("Oh dear, some Arson happened.");
            return new List<IConsequence> { new Heat(1), new PrisonTime(1000) };
        }

        public int GetSeverity()
        {
            return 5;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ICrime myFavouriteCrime = new Arson();

            foreach (IConsequence con in myFavouriteCrime.Commit())
            {
                Console.WriteLine(con.GetDescription());
            }

            Console.ReadKey();
        }
    }
}
