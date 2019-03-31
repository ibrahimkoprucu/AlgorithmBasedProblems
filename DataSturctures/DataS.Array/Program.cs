using System;

namespace DataS.Array
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var IDs1 = new int[] { 1, 2, 3, 4, 5 };
            var IDs2 = new int[5] { 1, 2, 3, 4, 5 };
            int[] IDs3 = { 1, 2, 3, 4, 5 };
            int[] IDs4 = new int[5] { 1, 2, 3, 4, 5 };
            int[] IDs5 = new int[5] { 1, 2, 3, 4, 5 };

            var BlankInts = new int[5];

            int[,] IDGrid = { { 1, 2 }, { 3, 4 } };

            for (int i = 0; i < IDGrid.GetLength(0); i++)
            {
                for (int j = 0; j < IDGrid.GetLength(1); j++)
                {
                    Console.WriteLine(IDGrid[i, j]);
                }
            }

            int[][] IDRows = { new int[] { 1, 2, 3 }, new int[] { 4, 5 } };//jagged array

            var LengthRow1 = IDRows[0].Length;
            var LengthRow2 = IDRows[1].Length;

            IDRows[0][1] = 12;// modified number 2 in the first row

            Console.WriteLine();
            foreach (var x in IDGrid)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            Console.WriteLine(IDs1.Rank);
            Console.WriteLine(IDs1.Length);
            Console.WriteLine(IDs1.GetLength(0));
            Console.WriteLine();

            for (int i = 0; i < IDs1.Length; i++)
            {
                Console.WriteLine(IDs1[i]);
            }

            Console.WriteLine();

            foreach (var ID in IDs1)
            {
                Console.WriteLine(ID);
            }

            Console.WriteLine();
        }
    }
}