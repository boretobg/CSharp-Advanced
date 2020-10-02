using System;
using System.IO;
using System.IO.Compression;

namespace _04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new FileStream("../../../copyMe.png", FileMode.Open))
            {
                using (var writer = new FileStream("../../../final.png", FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    while (reader.CanRead)
                    {
                        int readBytes = reader.Read(buffer, 0, buffer.Length);

                        if (readBytes == 0)
                        {
                            break;
                        }
                        writer.Write(buffer, 0, buffer.Length);
                    }
                }

            }
        }
    }
}
