using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace L155___Polymorphism
{
    internal class Program
    {
        public class Hat
        {
            public int x = 6;

            public virtual string SayHello()
            {
                return "Hello, I am a hat!";
            }
        }

        public class BowlerHat : Hat
        {
            public int y = 3;

            public override string SayHello()
            {
                return "Hello, I am a Bowler Hat!!";
            }
        }

        public class HardHat : Hat
        {
            public override string SayHello()
            {
                string s = base.SayHello();
                return s + "\n\nHello, it's me, the Hard Hat!!!!!";
            }
        }

        static void Main(string[] args)
        {
            List<Hat> hats = new List<Hat>();

            hats.Add(new BowlerHat());
            hats.Add(new BowlerHat());
            hats.Add(new HardHat());
            hats.Add(new Hat());

            foreach(Hat hat in hats)
            {
                Console.WriteLine(hat.SayHello());
            }

            Console.ReadKey();
        }
    }
}
