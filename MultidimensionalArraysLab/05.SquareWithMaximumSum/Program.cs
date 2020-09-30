using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];

            for (int b = 0; b < matrix.GetLength(0); b++)
            {
                int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[b, j] = nums[j];
                }
            }

            int max = int.MinValue;
            int sum = 0;
            int[,] output = new int[2, 2];
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                sum = 0;
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > max)
                    {
                        max = sum;
                        output[0, 0] = matrix[row, col];
                        output[1, 0] = matrix[row, col + 1];
                        output[0, 1] = matrix[row + 1, col];
                        output[1, 1] = matrix[row + 1, col + 1];
                    }
                }
            }

            Console.WriteLine(output[0, 0] + " " + output[1, 0]);
            Console.WriteLine(output[0, 1] + " " + output[1, 1]);
            Console.WriteLine(max);
        }
    }
}
