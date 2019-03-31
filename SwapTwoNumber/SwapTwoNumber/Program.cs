using System;

namespace SwapTwoNumbers
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Swap

            Console.WriteLine("Lütfen iki sayı giriniz");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("After swapping: x={0},y={1}", x, y);

            //Swap Again
            x = x * y;
            y = x / y;
            x = x / y;

            Console.WriteLine("After swapping again: x={0},y={1}", x, y);
        }
    }
}