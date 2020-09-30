using System;
using System.IO;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("../../../HOW TO RUN GAME!!.txt");
            using (reader)
            {
                int count = 0;
                string line = reader.ReadLine();
                using (var writer = new StreamWriter("../../../how ro run game.txt"))
                {
                    while (line != null)
                    {
                        if (count % 2 == 0)
                        {
                            writer.WriteLine(line);
                        }
                        count++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
