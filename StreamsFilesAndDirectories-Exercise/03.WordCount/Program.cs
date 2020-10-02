using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("../../../words.txt");
            string[] text = File.ReadAllLines("../../../text.txt");

            char[] trash = new char[] { '-', ',', '.', '!', '?', ' ' };

            var list = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                string[] splitted = text[i].Split(trash);
                for (int j = 0; j < splitted.Length; j++)
                {
                    list.Add(splitted[j]);
                }
            }

            var dict = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                int count = 0;
                dict.Add(words[i], count);
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].ToLower() == words[i])
                    {
                        dict[words[i]]++;
                    }
                }
            }

            using var writer = new StreamWriter("../../../actual.txt");
            foreach (var item in dict)
            {
                writer.WriteLine($"{item.Key} - {item.Value}");
            }

            var sorted = dict.OrderByDescending(x => x.Value);
            using var writer2 = new StreamWriter("../../../expected.txt");
            foreach (var item in sorted)
            {
                writer2.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
