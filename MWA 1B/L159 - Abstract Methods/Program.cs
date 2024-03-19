using System;

namespace L159___Abstract_Methods
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }
    public class Circle : Shape
    {
        private double radius;

        public Circle(double inR)
        {
            radius = inR;
        }

        public override double GetArea()
        {
            return radius * radius * Math.PI;
        }
    }
    public class Square : Shape
    {
        private double sideLength;

        public Square(double side)
        {
            sideLength = side;
        }

        public override double GetArea()
        {
            return sideLength * sideLength;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Shape myShape = new Square(3);

            Console.WriteLine(myShape.GetArea());

            Console.ReadKey();
        }
    }
}
