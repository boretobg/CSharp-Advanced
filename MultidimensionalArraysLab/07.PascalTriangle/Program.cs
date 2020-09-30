using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] jagged = new long[n][];
            int cols = 1;

            for (int row = 0; row < jagged.Length; row++)
            {
                jagged[row] = new long[cols];
                jagged[row][0] = 1;
                jagged[row][jagged[row].Length - 1] = 1;

                if (row > 1)
                {
                    for (int col = 1; col <= row - 1; col++)
                    {
                        jagged[row][col] = jagged[row - 1][col - 1] + jagged[row - 1][col];
                    }
                }
                cols++;
            }

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
