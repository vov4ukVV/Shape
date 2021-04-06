using System;
using System.Collections.Generic;

namespace Shape
{
    public abstract class Shape : IComparable
    {

        public double square { get; set; }
        public string name { get; set; }
        public int CompareTo(object o)
        {
            Shape p = o as Shape;
            if (p != null)
                return this.square.CompareTo(p.square);
            else
                throw new Exception("помилка порівняння");
        }
        public abstract double square_search();
    }
    public class Circle : Shape
    {
        private double radius;
        private double pi = Math.PI;
        public Circle(double radius)
        {
            this.radius = radius;
            square = square_search();
            name = "коло";
        }

        public override double square_search()
        {
            return radius * radius * pi;
        }
    }
    public class Square : Shape
    {
        private double widht { get; set; }
        public Square(double width)
        {
            this.widht = width;
            square = square_search();
            name = "квадрат";
        }

        public override double square_search()
        {
            return widht * widht;
        }
    }
    public class Rectangle : Shape
    {
        private double height { get; set; }
        private double width { get; set; }
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
            square = square_search();
            name = "прямокутник";
        }

        public override double square_search()
        {
            return width * height;
        }
    }
    public class Triangle : Shape
    {
        private double height { get; set; }
        private double width { get; set; }
        public Triangle(int width, int height)
        {
            this.width = width;
            this.height = height;
            square = square_search();
            name = "трикутник";

        }
        public override double square_search()
        {
            return height * width / 2;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            Shape s1 = new Circle(4);
            Shape s2 = new Square(3);
            Shape s3 = new Triangle(2, 3);
            Shape s4 = new Rectangle(2, 3);
            List<Shape> ss = new List<Shape>();
            ss.Add(s1);
            ss.Add(s2);
            ss.Add(s3);
            ss.Add(s4);
            ss.Sort();
            foreach (Shape s in ss)
            {
                Console.WriteLine($"{s.name} має площу:{s.square}");


            }

        }

    }
}
