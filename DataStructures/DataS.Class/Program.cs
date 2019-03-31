using System;

namespace DataS.Class
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var Shape = new Shape();
            Shape square = new Square(5.0);
            Console.WriteLine(square.Area);
            Shape triangle = new Triangle(3, 5);
            Console.WriteLine(triangle.Area);
            Shape s = triangle + square;
            Console.WriteLine(s);
        }
    }

    public class Shape
    {
        public virtual string Name
        {
            get { return "Unknown"; }
        }

        public virtual int NumSides
        {
            get { throw new InvalidOperationException(); }
        }

        private double _Area = 0;

        public virtual double Area
        {
            get
            {
                return _Area;
            }
        }

        public static Shape operator +(Shape a, Shape b)
        {
            var newShape = new Shape();
            newShape._Area = a.Area + b.Area;
            return newShape;
        }

        public override string ToString() => Area.ToString();
    }

    public class Square : Shape
    {
        private double _Size;

        public Square(double Size)
        {
            _Size = Size;
        }

        public override string Name
        {
            get { return "Square"; }
        }

        public override int NumSides
        {
            get { return 4; }
        }

        public override double Area
        {
            get { return _Size * _Size; }
        }
    }

    public class Triangle : Shape
    {
        private double b;
        private double h;

        public Triangle(double b, double h)
        {
            this.b = b;
            this.h = h;
        }

        public override string Name
        {
            get { return "Triangle"; }
        }

        public override int NumSides
        {
            get { return 3; }
        }

        public override double Area
        {
            get { return b * h / 2; }
        }
    }
}