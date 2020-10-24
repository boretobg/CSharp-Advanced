using System;
using System.Linq;
using System.Net;
using System.Numerics;

namespace PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPresents = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int niceKids = 0;
            int row = 0;
            int col = 0;

            for (int rows = 0; rows < n; rows++)
            {
                char[] line = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = line[cols];
                    if (matrix[rows, cols] == 'S')
                    {
                        row = rows;
                        col = cols;
                    }

                    if (matrix[rows, cols] == 'V')
                    {
                        niceKids++;
                    }
                }
            }

            int allKids = niceKids;
            bool noPresents = false;
            string input = Console.ReadLine();
            while (input != "Christmas morning")
            {
                matrix[row, col] = '-';
                if (input == "up")
                {
                    row--;
                }
                else if (input == "down")
                {
                    row++;
                }
                else if (input == "left")
                {
                    col--;
                }
                else if (input == "right")
                {
                    col++;
                }

                if (matrix[row, col] == 'V')
                {
                    niceKids--;
                    countOfPresents--;
                }
                else if (matrix[row, col] == 'C')
                {
                    Cookie(matrix, row, col, ref niceKids, ref countOfPresents);
                }

                if (countOfPresents == 0)
                {
                    noPresents = true;
                    break;
                }
                if (niceKids == 0)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (noPresents)
            {
                Console.WriteLine("Santa ran out of presents!");
            }

            matrix[row, col] = 'S';
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write(matrix[rows, cols]);
                }
                Console.WriteLine();
            }

            if (niceKids == 0)
            {
                Console.WriteLine($"Good job, Santa! {allKids} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {niceKids} nice kid/s.");
            }
        }

        public static void Cookie(char[,] matrix, int row, int col, ref int niceKids, ref int countOfPresents)
        {
            if (matrix[row - 1, col] == 'V' || matrix[row - 1, col] == 'X') //up
            {
                countOfPresents--;
                if (matrix[row - 1, col] == 'V')
                {
                    niceKids--;
                }
                matrix[row - 1, col] = '-';
            }
            if (matrix[row + 1, col] == 'V' || matrix[row + 1, col] == 'X') //down
            {
                countOfPresents--;
                if (matrix[row + 1, col] == 'V')
                {
                    niceKids--;
                }
                matrix[row + 1, col] = '-';
            }
            if (matrix[row, col - 1] == 'V' || matrix[row, col - 1] == 'X') //left
            {
                countOfPresents--;
                if (matrix[row, col - 1] == 'V')
                {
                    niceKids--;
                }
                matrix[row, col - 1] = '-';
            }
            if (matrix[row, col + 1] == 'V' || matrix[row, col + 1] == 'X') //right
            {
                countOfPresents--;
                if (matrix[row, col + 1] == 'V')
                {
                    niceKids--;
                }
                matrix[row, col + 1] = '-';
            }
        }
    }
}
