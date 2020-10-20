using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            int row = 0;
            int col = 0;
            int food = 0;

            for (int rows = 0; rows < n; rows++)
            {
                string input = Console.ReadLine();
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (matrix[rows, cols] == 'S')
                    {
                        row = rows;
                        col = cols;
                    }
                }
            }

            bool isOver = false;

            while (!isOver)
            {
                string direction = Console.ReadLine();
                if (direction == "left")
                {
                    matrix[row, col] = '.';
                    col--;
                    if (col >= 0)
                    {
                        ObjectCheck(n, matrix, ref row, ref col, ref food);
                    }
                    else
                    {
                        isOver = true;
                    }
                }
                else if (direction == "right")
                {
                    matrix[row, col] = '.';
                    col++; 
                    if (col < n)
                    {
                        ObjectCheck(n, matrix, ref row, ref col, ref food);
                    }
                    else
                    {
                        isOver = true;
                    }
                }
                else if (direction == "up")
                {
                    matrix[row, col] = '.';
                    row--;
                    if (row >= 0)
                    {
                        ObjectCheck(n, matrix, ref row, ref col, ref food);
                    }
                    else
                    {
                        isOver = true;
                    }
                }
                else if (direction == "down")
                {
                    matrix[row, col] = '.';
                    row++;
                    if (row < n)
                    {
                        ObjectCheck(n, matrix, ref row, ref col, ref food);
                    }
                    else
                    {
                        isOver = true;
                    }
                }

                if (food >= 10)
                {
                    matrix[row, col] = 'S';
                    break;
                }
            }

            if (isOver)
            {
                Console.WriteLine("Game over!");
                Console.WriteLine($"Food eaten: {food}");
            }
            else
            {
                Console.WriteLine("You won! You fed the snake.");
                Console.WriteLine($"Food eaten: {food}");
            }

            PrintMatrix(n, matrix);
        }

        static void PrintMatrix(int n, char[,] matrix)
        {
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write(matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }
        static void ObjectCheck(int n, char[,] matrix, ref int row, ref int col, ref int food)
        {
            if (matrix[row, col] == '*')
            {
                food++;
                matrix[row, col] = '.';
            }
            else if (matrix[row, col] == 'B')
            {
                matrix[row, col] = '.';
                for (int rows = 0; rows < n; rows++)
                {
                    for (int cols = 0; cols < n; cols++)
                    {
                        if (matrix[rows, cols] == 'B')
                        {
                            matrix[rows, cols] = '.';
                            row = rows;
                            col = cols;
                        }
                    }
                }
            }
        }
    }
}
