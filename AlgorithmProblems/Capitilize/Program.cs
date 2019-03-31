using System;

namespace Capitilize
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var inputWord = "quick brown fox jumps";

            var resultArray = FillIntoArray(inputWord);

            foreach (var s in resultArray)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }

        private static int FindWordCount(string str)
        {
            int wordCount = 1;//Boşluktan  1 fazla kelime olmalı
            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    wordCount++;
                }
            }
            return wordCount;
        }

        private static string[] FillIntoArray(string str)
        {
            int size = FindWordCount(str);
            string[] words = new string[size];
            string temp = string.Empty;
            int k = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    words[k] = temp;
                    k++;
                    temp = string.Empty;
                }
                else
                {
                    temp += str[i];
                }
            }
            words[k] = temp;

            return words;
        }
    }
}