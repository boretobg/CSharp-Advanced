using System;
using System.IO;

namespace _06.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("../../../TestFolder"); //fileinfo
            double sum = 0;
            foreach (var item in files)
            {
                FileInfo info = new FileInfo(item);
                sum += info.Length;
            }

            sum = sum / 1024 / 1024;
            File.WriteAllText("../../../output.txt", sum.ToString());
        }
    }
}
