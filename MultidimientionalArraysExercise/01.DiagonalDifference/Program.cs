using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            int sumFirst = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int col = row;
                sumFirst += matrix[row, col];
            }

            int sumSecond = 0;
            int secondCol = 0;
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                sumSecond += matrix[row, secondCol];
                secondCol++;
            }

            Console.WriteLine(Math.Abs(sumFirst - sumSecond));
        }
    }
}
