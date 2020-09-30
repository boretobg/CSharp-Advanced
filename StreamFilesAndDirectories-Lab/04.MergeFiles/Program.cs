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
            using (var reader = new StreamReader("../../../first.txt"))
            {
                int num = int.Parse(reader.ReadLine());
                
            }

            using (var reader2 = new StreamReader("../../../second.txt"))
            {
                list.Add(int.Parse(reader2.ReadLine()));
            }

            list.Sort();

            using (var writer = new StreamWriter("../../../sorted.txt"))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    writer.WriteLine(list[i]);
                }
            }
        }
    }
}
