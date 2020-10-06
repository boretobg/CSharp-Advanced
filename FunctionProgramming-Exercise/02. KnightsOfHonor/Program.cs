using System;

namespace _02._KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Action<string[]> print = PrintWords;
            print(words);
        }

        static void PrintWords(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"Sir {words[i]}");
            }
        }
    }
}
