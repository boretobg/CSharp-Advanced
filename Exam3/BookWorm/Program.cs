using System;

namespace BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int row = 0;
            int col = 0;

            for (int rows = 0; rows < n; rows++)
            {
                string input = Console.ReadLine();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (matrix[rows, cols] == 'P')
                    {
                        row = rows;
                        col = cols;
                    }
                }
            }

            string line = string.Empty;
            while (line != "end")
            {
                line = Console.ReadLine();
                if (line == "up")
                {
                    matrix[row, col] = '-';
                    if (row - 1 < 0)
                    {
                        RemoveLast(ref word);
                        continue;
                    }
                    row--;
                    IsLetter(matrix, row, col, ref word);
                }
                else if (line == "down")
                {
                    matrix[row, col] = '-';
                    if (row + 1 >= n)
                    {
                        RemoveLast(ref word);
                        continue;
                    }
                    row++;
                    IsLetter(matrix, row, col, ref word);
                }
                else if (line == "left")
                {
                    matrix[row, col] = '-';
                    if (col - 1 < 0)
                    {
                        RemoveLast(ref word);
                        continue;
                    }
                    col--;
                    IsLetter(matrix, row, col, ref word);
                }
                else if (line == "right")
                {
                    matrix[row, col] = '-';
                    if (col + 1 >= n)
                    {
                        RemoveLast(ref word);
                        continue;
                    }
                    col++;
                    IsLetter(matrix, row, col, ref word);
                }
            }

            matrix[row, col] = 'P';
            Console.WriteLine(word);
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write(matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }

        static void IsLetter(char[,] matrix, int row, int col, ref string word)
        {
            if (matrix[row,col] != '-')
            {
                char letter = matrix[row, col];
                word += letter;
            }
        }

        static void RemoveLast(ref string word)
        {
            if (word.Length > 0)
            {
                word = word.Remove(word.Length - 1);
            }
        }
    }
}
