using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1___Polymorphism___Part_3
{
    abstract class Shape
    {
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
        public virtual string Draw()
        {
            return "";
        }
    }
    class Rectangle : Shape
    {
        protected double height { get; set; }
        protected double width { get; set; }
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public override double CalculatePerimeter()
        {
            return (height + width) * 2;
        }
        public override double CalculateArea()
        {
            return height * width;
        }
        public override string Draw()
        {
            return base.Draw();
        }
    }
    class Circle : Shape
    {
        protected double radius { get; set; }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double CalculatePerimeter()
        {
            return Math.PI * radius * radius;
        }
        public override double CalculateArea()
        {
            return 2 * Math.PI * radius;
        }
        public override string Draw()
        {
            return base.Draw();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Height of the rectangle: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Width of the rectangle: ");
            double w = Convert.ToDouble(Console.ReadLine());
            Shape rec = new Rectangle(h, w);
            Console.WriteLine("Perimeter and area of the rectangle: {0} ; {1}", rec.CalculatePerimeter(), rec.CalculateArea());
            Console.WriteLine("Radius of the circle: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Shape cir = new Circle(5.5);
            Console.WriteLine("Perimeter and area of the circle: {0} ; {1}", cir.CalculatePerimeter(), cir.CalculateArea());
            Console.ReadKey();
        }
    }
}
