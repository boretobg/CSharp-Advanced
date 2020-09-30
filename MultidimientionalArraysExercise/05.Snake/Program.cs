using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace _05.Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[size[0], size[1]];

            string word = Console.ReadLine();


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = word[0].ToString();
                        string temp = word[0].ToString();
                        word = word.Remove(0, 1);
                        word = word.Insert(word.Length, temp);
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = word[0].ToString();
                        string temp = word[0].ToString();
                        word = word.Remove(0, 1);
                        word = word.Insert(word.Length, temp);
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
