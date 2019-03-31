using System;

namespace ReverseAnIntArray
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Reverse(ar);

            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }

            Console.WriteLine();
            Reverse2(ar);

            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }

            Console.WriteLine();
            Reverse3(ar);

            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }
        }

        private static void Reverse(int[] A)
        {
            for (int i = 0; i < A.Length / 2; i++) //untill get to midpoint
            {
                int temp = A[i];
                A[i] = A[A.Length - i - 1];
                A[A.Length - i - 1] = temp;
            }
        }

        private static void Reverse2(int[] A)//Alternative way
        {
            int temp = 0;

            for (int i = 0, j = A.Length - 1; i < j; i++, j--)//in the midpoint i==j or i>j if length is even  loop ends
            {
                temp = A[i];
                A[i] = A[j];
                A[j] = temp;
            }
        }

        private static void Reverse3(int[] A)
        {
            int k = 0;
            int l = A.Length - 1;

            while (/*k < l*/ k < A.Length / 2)
            {
                int temp = A[k];
                A[k] = A[l];
                A[l] = temp;
                k++;
                l--;
            }
        }
    }
}