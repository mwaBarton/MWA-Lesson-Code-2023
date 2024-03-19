using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return 4 * Math.PI * radius * radius;
        }

        public override double GetVolume()
        {
            return 4 / 3 * Math.PI * Math.Pow(radius, 3);
        }
    }

    public class Triangle : Shape
    {
        private double width, height;

        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height / 2;
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
