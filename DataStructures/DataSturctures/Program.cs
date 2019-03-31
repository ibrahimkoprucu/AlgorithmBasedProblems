using System;

namespace DataStructures
{
  public class Program
  {
    private static void Main(string[] args)
    {
      Point a = new Point(1, 2);
      //a.X = 1;
      //a.Y = 2;
      Console.WriteLine(value: a.Y);
      Console.WriteLine(value: a.X);
      Point result = a + new Point(4, 6);
      Console.WriteLine(result);//ToString override edilmezse result={DataStructures.Program.Point}
      double distance = a.DistanceFrom(new Point(4, 6));
      Console.WriteLine(distance);
      Console.WriteLine();
    }

    private struct Point
    {
      public double X;
      public double Y;

      public Point(double X, double Y)
      {
        this.X = X;
        this.Y = Y;
      }

      public static Point operator +(Point a, Point b) //Point tipinde bir değer dönecek ,operator overloading
      {
        return new Point(a.X + b.X, a.Y + b.Y);
      }

      public override string ToString()
      {
        return String.Format($"{this.X},{this.Y}");
      }

      public double DistanceFrom(Point that)
      {
        double x = Math.Abs(this.X - that.X);
        double y = Math.Abs(this.Y - that.Y);
        double h;
        h = Math.Sqrt(x * x + y * y);
        return h;
      }
    }
  }
}