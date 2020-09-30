using System;
using System.Data;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            int max = int.MinValue;
            string first = string.Empty;
            string second = string.Empty;
            string third = string.Empty;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                int sum = 0;
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > max)
                    {
                        max = sum;
                        first = matrix[row, col] + " " + matrix[row, col + 1] + " " + matrix[row, col + 2];
                        second = matrix[row + 1, col] + " " + matrix[row + 1, col + 1] + " " + matrix[row + 1, col + 2];
                        third = matrix[row + 2, col] + " " + matrix[row + 2, col + 1] + " " + matrix[row + 2, col + 2];
                    }
                }
            }

            Console.WriteLine($"Sum = {max}");
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
        }
    }
}
