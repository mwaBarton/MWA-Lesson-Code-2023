using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L164___Interfaces
{
   

    interface IFruit
    {
        void Peel();
        bool IsRipe(DateTime timeToCheck);
        double Explode();
    }

    class Banana : IFruit
    {
        DateTime bestBefore;

        public double Explode()
        {
            Console.WriteLine("bang.");
            return (new Random()).NextDouble();
        }

        public bool IsRipe(DateTime timeToCheck)
        {

            if ((timeToCheck - bestBefore).TotalDays > 3)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public void Peel()
        {
            Console.WriteLine("Banana is peeled");
        }
    }


    public interface A
    {
        void DoIT();
    }
    public interface B
    {
        void DoIT();
    }

    public class C : A, B
    {
        public void DoIT()
        {
            Console.WriteLine("C");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a;
            IFruit b = new Banana();
            b.Explode();
        }
    }
}
