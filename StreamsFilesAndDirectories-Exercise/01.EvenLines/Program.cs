using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../../text.txt"))
            {
                int count = 0;

                using var writer = new StreamWriter("../../../output.txt");

                string line = reader.ReadLine();
                while (line != null)
                {
                    if (count % 2 == 0)
                    {
                        Regex regex = new Regex(@"-|,|\.|!|\?");
                        line = regex.Replace(line, "@");

                        string[] text = line.Split();
                        text = text.Reverse().ToArray();

                        string output = String.Empty;
                        for (int i = 0; i < text.Length; i++)
                        {
                            output += text[i] + " ";
                        }
                        writer.WriteLine(output);
                    }

                    count++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
