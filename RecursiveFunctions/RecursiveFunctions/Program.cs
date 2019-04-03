using System;

namespace RecursiveFunctions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IsimYazdır(5);
        }

        private static void IsimYazdır(int sayac)
        {
            if (sayac == 0)
            {
                return;
            }
            else
            {
                IsimYazdır(sayac - 1);
            }

            Console.Write("ibo ");
        }
    }
}