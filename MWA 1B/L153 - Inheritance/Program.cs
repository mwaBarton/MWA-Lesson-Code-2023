using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L153___Inheritance
{
    public class Rectangle
    {
        protected int width, height;
        public Rectangle(int inWidth, int inHeight)
        {
            width = inWidth;
            height = inHeight;
        }

        public Rectangle()
        {
            width = 3;
            height = 3;
        }

        public int getArea()
        {
            return width * height;
        }
    }
    public class Square : Rectangle
    {
        public string faveTopping;
        public Square(int sideLength, string topping)
        {
            faveTopping = topping;
            width = 5;
        }
    }

    public class JazzySquare : Square
    {
        public JazzySquare(int sideLength, string topping) : base(sideLength, topping)
        {
            width = 6;
        }

        public void JazzHands()
        {
            Console.WriteLine("Square has lost all its friends.");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(4, "Ham");

            Console.WriteLine(s.faveTopping + ": " + s.getArea());
            Console.WriteLine();
        }
    }
}
