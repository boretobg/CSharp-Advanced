using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                                    //col row
            int[,] array = new int[n[0], n[1]];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = nums[j];
                }
            }

            for (int i = 0; i < array.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    sum += array[j, i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
