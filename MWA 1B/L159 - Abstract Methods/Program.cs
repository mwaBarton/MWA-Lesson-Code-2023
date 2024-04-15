using System;

namespace L159___Abstract_Methods
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public abstract class Shape3D : Shape
    {
        public abstract double GetVolume();
    }

    public class Sphere : Shape3D
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }

        public override double GetVolume()
        {
            return 4 / 3 * Math.PI * Math.Pow(radius, 3);
        }
    }


    public class Trapezium : Shape
    {
        private double a, b, h;

        public Trapezium(double a, double b, double h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }

        public override double GetArea()
        {
            return 0.5 * (a + b) * h;
        }
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
