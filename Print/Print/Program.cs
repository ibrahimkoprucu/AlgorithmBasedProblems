using System;

namespace Print
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CrossStylePrint();

            int[] ar = { 1, 2, 3, 4, 5 };
            PrintNumbers(ar);
        }

        /// <summary>
        /// X0000
        /// 0X000
        /// 00X00
        /// 000X0
        /// 0000X
        /// </summary>
        private static void CrossStylePrint()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// 12345
        /// 1234
        /// 123
        /// 12
        /// 1
        /// </summary>
        private static void PrintNumbers(int[] A)
        {
            Console.WriteLine("------------");

            for (int j = 0; j < A.Length; j++)
            {
                for (int i = 0; i < A.Length - j; i++)
                {
                    Console.Write(A[i]);
                }

                Console.WriteLine();
            }

            Console.WriteLine("------------");
        }
    }
}