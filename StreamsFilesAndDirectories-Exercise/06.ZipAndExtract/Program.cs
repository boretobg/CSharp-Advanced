using System;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory("../../../copyme", "../../../zip.zip");
            ZipFile.ExtractToDirectory("../../../zip.zip", "C:/Users/Bobby/Desktop");
        }
    }
}
