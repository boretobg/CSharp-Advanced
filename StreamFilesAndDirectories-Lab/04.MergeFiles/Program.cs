using System;
using System.Collections.Generic;
using System.IO;

namespace _04.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            using (var readerOne = new StreamReader("../../../input1.txt"))
            {
                string line = "";
                while (true)
                {
                    line = readerOne.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    list.Add(int.Parse(line));
                }
            }

            using (var readerTwo = new StreamReader("../../../input2.txt"))
            {
                string line = "";
                while (true)
                {
                    line = readerTwo.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    list.Add(int.Parse(line));
                }
            }

            list.Sort();

            using (var writer = new StreamWriter("../../../output.txt"))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    writer.WriteLine(list[i]);
                }
            }

        }
    }
}
