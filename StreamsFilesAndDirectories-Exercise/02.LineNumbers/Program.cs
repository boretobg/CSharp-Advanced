using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("../../../text.txt");
            using var writer = new StreamWriter("../../../output.txt");

            for (int i = 0; i < text.Length; i++)
            {
                int letters = 0;
                int punct = 0;
                for (int j = 0; j < text[i].Length; j++)
                {
                    if (text[i][j] != ' ')
                    {
                        if (text[i][j] == '-' || text[i][j] == ',' || 
                            text[i][j] == '\'' || text[i][j] == '.')
                        {
                            punct++;
                            continue;
                        }
                        letters++;
                    }
                }
                writer.WriteLine($"Line {i + 1}: {text[i]}({letters})({punct})");

            }
        }
    }
}
