using System;
using System.Data;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int row = 0;
            int col = 0;

            char[,] matrix = new char[size, size];
            for (int rows = 0; rows < size; rows++)
            {
                string input = Console.ReadLine();
                for (int cols = 0; cols < size; cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (input[cols] == 'f')
                    {
                        row = rows;
                        col = cols;
                    }
                }
            }

            bool hasFailed = true;

            for (int i = 0; i < n; i++)
            {
                string direction = Console.ReadLine();
                if (direction == "up")
                {
                    if (row <= 0)
                    {
                        matrix[row, col] = '-';
                        row = size - 1;
                    }
                    else
                    {
                        matrix[row, col] = '-';
                        row--;
                    }

                    if (matrix[row, col] == 'B')
                    {
                        row--;
                    }
                    else if (matrix[row, col] == 'T')
                    {
                        row++;
                    }
                    else if (matrix[row, col] == 'F')
                    {
                        Console.WriteLine("Player won!");
                        matrix[row, col] = 'f';
                        hasFailed = false;
                        break;
                    }
                    else
                    {
                        matrix[row, col] = 'f';
                    }
                }
                else if (direction == "down")
                {
                    if (row >= size)
                    {
                        row = 0;
                    }
                    else
                    {
                        matrix[row, col] = '-';
                        row++;
                    }

                    if (matrix[row, col] == 'B')
                    {
                        row++;
                    }
                    else if (matrix[row, col] == 'T')
                    {
                        row--;
                    }
                    else if (matrix[row, col] == 'F')
                    {
                        Console.WriteLine("Player won!");
                        matrix[row, col] = 'f';
                        hasFailed = false;
                        break;
                    }
                    else
                    {
                        matrix[row, col] = 'f';
                    }
                }
                else if (direction == "right")
                {
                    if (col >= size)
                    {
                        col = 0;
                    }
                    else
                    {
                        matrix[row, col] = '-';
                        col++;
                    }

                    if (matrix[row, col] == 'B')
                    {
                        col++;
                    }
                    else if (matrix[row, col] == 'T')
                    {
                        col--;
                    }
                    else if (matrix[row, col] == 'F')
                    {
                        Console.WriteLine("Player won!");
                        matrix[row, col] = 'f';
                        hasFailed = false;
                        break;
                    }
                    else
                    {
                        matrix[row, col] = 'f';
                    }
                }
                else if (direction == "left")
                {
                    if (col <= 0)
                    {
                        col = size - 1;
                    }
                    else
                    {
                        matrix[row, col] = '-';
                        col--;
                    }

                    if (matrix[row, col] == 'B')
                    {
                        col--;
                    }
                    else if (matrix[row, col] == 'T')
                    {
                        col++;
                    }
                    else if (matrix[row, col] == 'F')
                    {
                        Console.WriteLine("Player won!");
                        matrix[row, col] = 'f';
                        hasFailed = false;
                        break;
                    }
                    else
                    {
                        matrix[row, col] = 'f';
                    }
                }
            }

            if (hasFailed)
            {
                Console.WriteLine("Player lost!");
            }

            for (int rows = 0; rows < size; rows++)
            {
                for (int cols = 0; cols < size; cols++)
                {
                    Console.Write(matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }
    }
}
