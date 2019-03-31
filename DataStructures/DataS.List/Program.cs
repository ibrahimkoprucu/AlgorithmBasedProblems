using System;
using System.Collections.Generic;
using System.Linq;

namespace DataS.List
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var L = new List<int>() { 1, 2, 3, 4 };

            foreach (var i in L)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < L.Count(); i++)
            {
                L[i]++;
            }

            L.Insert(0, 5);
        }
    }
}