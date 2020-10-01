using System;
using System.Collections.Generic;
using System.IO;

namespace _05.SliceFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var slicer = new List<string>();
            using (var reader = new StreamReader("../../../TargetFile.txt"))
            {
                var temp = string.Empty;
                while (true)
                {
                    temp = reader.ReadLine();
                    if (temp == null)
                    {
                        break;
                    }
                    slicer.Add(temp);
                }
            }

            for (int i = 1; i <= slicer.Count; i++)
            {
                using (var writer = new StreamWriter($"../../../Sliced{i}.txt"))
                {
                    writer.WriteLine(slicer[i - 1]);
                }
            }
        }
    }
}
