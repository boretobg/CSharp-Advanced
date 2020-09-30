using System;
using System.Linq;
using System.Net.Http.Headers;

namespace _2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] letters = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = letters[col];
                }
            }

            int count = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                string target = "";
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        target = matrix[row, col];
                        if (matrix[row + 1, col] == target && target == matrix[row + 1, col + 1])
                        {
                            count++;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
