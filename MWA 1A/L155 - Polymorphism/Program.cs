using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L155___Polymorphism
{
    public class Shape
    {
        public virtual double getArea()
        {
            Console.WriteLine("Shape");
            return 0;
        }
    }

    public class Square : Shape
    {
        private double sideLength;
        public Square(double side)
        {
            sideLength = side;
        }

        public override double getArea()
        {
            base.getArea();
            Console.WriteLine("Square");
            return sideLength * sideLength;
        }
    }

    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double getArea()
        {
            Console.WriteLine("Circle");
            return radius * radius * Math.PI;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // The data type of an object reference 
            // doesn't need to be the same as the data type
            // of the object it refers to

            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Square(5));
            shapes.Add(new Square(7));
            shapes.Add(new Circle(2));
            shapes.Add(new Circle(3));
            shapes.Add(new Shape());

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.getArea());
            }
            Console.ReadKey();
        }
    }
}
