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

        public int getArea()
        {
            return width * height;
        }
    }
    public class Square : Rectangle
    {
        public string faveTopping;

        public Square(int sideLength, string pizzaaaaa) : base (sideLength, sideLength)
        {
            faveTopping = pizzaaaaa;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(5, "ham");


            Rectangle r = s;

            Square sAgain = (Square)r;

            sAgain.faveTopping = "Hi";

            Console.WriteLine(s.getArea());

            Console.ReadKey();

        }
    }
}
