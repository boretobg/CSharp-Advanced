using System;
using System.ComponentModel;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../../TextFile1.txt"))
            {
                string line = reader.ReadLine();
                int count = 1;
                using (var writer = new StreamWriter("../../../numberedText.txt"))
                {
                    while (line != null)
                    {
                        writer.WriteLine($"{count}. {line}");
                        count++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
