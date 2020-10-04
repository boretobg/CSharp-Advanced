using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Directory.GetFiles("../../../");

            var file = new SortedDictionary<string, SortedDictionary<string, long>>();

            for (int i = 0; i < array.Length; i++)
            {
                FileInfo fi = new FileInfo(array[i]);
                string name = Path.GetFileNameWithoutExtension(array[i]);
                string ext = Path.GetExtension(array[i]);
                long size = fi.Length;

                if (!file.ContainsKey(ext))
                {
                    file.Add(ext, new SortedDictionary<string, long>());
                }

                file[ext].Add(name, size);
            }

            var list = file.OrderByDescending(n => n.Value.Values.Count);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (var writer = new StreamWriter($"{path}/output.txt"))
            {
                foreach (var ext in list)
                {
                    writer.WriteLine(ext.Key);
                    foreach (var item in ext.Value)
                    {
                        writer.WriteLine($"--{item.Key} - {item.Value}kb");
                    }
                }

            }
        }
    }
}
