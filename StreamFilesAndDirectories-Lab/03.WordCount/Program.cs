using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string>();
            using (var readerWords = new StreamReader("../../../words.txt"))
            {
                words = readerWords.ReadLine().Split().ToList();
            }
            var list = new List<string>();
            using (var readerText = new StreamReader("../../../input.txt"))
            {
                char[] splitters = new char[] { ' ', '.', ',', '!', '?', '-' };

                while (true)
                {
                    string line = readerText.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] text = line.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < text.Length; i++)
                    {
                        list.Add(text[i].ToLower());
                    }
                }
            }

            var final = new Dictionary<string, int>();
            int count = 0;
            for (int i = 0; i < words.Count; i++)
            {
                final.Add(words[i], 0);
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] == words[i])
                    {
                        final[words[i]]++;
                    }
                }
            }

            var output = final.OrderByDescending(x => x.Value).ToList();

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
