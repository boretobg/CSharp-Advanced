using System;

namespace _01.ActionPoint
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
            Console.WriteLine(string.Join("\n", words));
        }

    }
}
