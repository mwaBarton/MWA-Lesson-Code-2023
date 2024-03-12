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
        public string pizzaTopping;

        public Square(int sideLength, string favePizzaTopping)
        {
            width = 3;

            pizzaTopping = favePizzaTopping;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(4, "Squarepperoni");

            

            Console.WriteLine(s.pizzaTopping + ": " + s.getArea());
            Console.ReadKey();
        }
    }
}
