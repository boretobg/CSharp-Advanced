using System;
using System.Runtime.CompilerServices;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
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
                    if (matrix[rows, cols] == 'B')
                    {
                        row = rows;
                        col = cols;
                    }
                }
            }

            int flowers = 0;

            bool isOutside = false;
            string line = String.Empty;
            while (line != "End")
            {
                line = Console.ReadLine();
                if (line == "up")
                {
                    matrix[row, col] = '.';
                    if (row - 1 < 0)
                    {
                        isOutside = true;
                        break;
                    }
                    row--;
                    CheckInFront(matrix, ref row, ref col, ref flowers, line, isOutside, n);
                }
                else if (line == "down")
                {
                    matrix[row, col] = '.';
                    if (row + 1 >= n)
                    {
                        isOutside = true;
                        break;
                    }
                    row++;
                    CheckInFront(matrix, ref row, ref col, ref flowers, line, isOutside, n);
                }
                else if (line == "right")
                {
                    matrix[row, col] = '.';
                    if (col + 1 >= n)
                    {
                        isOutside = true;
                        break;
                    }
                    col++;
                    CheckInFront(matrix, ref row, ref col, ref flowers, line, isOutside, n);
                }
                else if (line == "left")
                {
                    matrix[row, col] = '.';
                    if (col - 1 < 0)
                    {
                        isOutside = true;
                        break;
                    }
                    col--;
                    CheckInFront(matrix, ref row, ref col, ref flowers, line, isOutside, n);
                }

                if (isOutside)
                {
                    break;
                }
            }

            if (isOutside)
            {
                Console.WriteLine("The bee got lost!");
            }

            if (flowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {Math.Abs(5 - flowers)} flowers more");
                matrix[row, col] = 'B';
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowers} flowers!");
            }


            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write(matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }

        private static void CheckInFront(char[,] matrix, ref int row, ref int col, ref int flowers, string line, bool isOutside, int n)
        {
            if (matrix[row, col] == 'f')
            {
                flowers++;
                matrix[row, col] = '.';
            }
            else if (matrix[row, col] == 'O')
            {
                matrix[row, col] = '.';
                if (line == "up")
                {
                    if (row - 1 < 0)
                    {
                        isOutside = true;
                        return;
                    }
                    row--;
                }
                else if (line == "down")
                {
                    if (row + 1 >= n)
                    {
                        isOutside = true;
                        return;
                    }
                    row++;
                }
                else if (line == "left")
                {
                    if (col - 1 < 0)
                    {
                        isOutside = true;
                        return;
                    }
                    col--;
                }
                else if (line == "right")
                {
                    if (col + 1 >= n)
                    {
                        isOutside = true;
                        return;
                    }
                    col++;
                }
            }
        }
    }
}
