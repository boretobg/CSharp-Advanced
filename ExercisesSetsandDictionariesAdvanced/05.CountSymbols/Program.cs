using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var hashSet = new HashSet<char>();
            var dictionary = new SortedDictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (dictionary.ContainsKey(text[i]))
                {
                    dictionary[text[i]]++;
                    continue;
                }
                dictionary.Add(text[i], 1);
            }

            var list = dictionary.ToList();

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
