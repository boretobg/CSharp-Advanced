using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];

            for (int rows = 0; rows < size[0]; rows++) //making the "garden"
            {
                for (int cols = 0; cols < size[1]; cols++)
                {
                    matrix[rows, cols] = 0;
                }
            }

            var locations = new List<int[]>();

            string input = Console.ReadLine();
            while (input != "Bloom Bloom Plow") // adding all locations to a list
            {
                int[] flowerLocation = input.Split().Select(int.Parse).ToArray();
                if ((flowerLocation[0] < 0 || flowerLocation[0] >= size[0]) ||
                    (flowerLocation[1] < 0 || flowerLocation[1] >= size[1])) // checks if location is outside of border
                {
                    Console.WriteLine("Invalid coordinates.");
                    input = Console.ReadLine();
                    continue;
                }
                locations.Add(flowerLocation);
                input = Console.ReadLine();
            }

            for (int i = 0; i < locations.Count; i++)
            {
                CheckForFlowers(matrix, locations[i][0], locations[i][1], size[0], size[1]);
            }

            for (int rows = 0; rows < size[0]; rows++)
            {
                for (int cols = 0; cols < size[1]; cols++)
                {
                    Console.Write(matrix[rows, cols] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void CheckForFlowers(int[,] matrix, int row, int col, int N, int M)
        {
            int ROW = row;
            int COL = col;
            matrix[row, col]++;
            while (true) //left
            {
                col--;
                if (col < 0)
                {
                    row = ROW;
                    col = COL;
                    break;
                }
                matrix[row, col]++;
            }
            while (true) //right
            {
                col++;
                if (col >= M)
                {
                    row = ROW;
                    col = COL;
                    break;
                }
                matrix[row, col]++;
            }
            while (true) //up
            {
                row--;
                if (row < 0)
                {
                    row = ROW;
                    col = COL;
                    break;
                }
                matrix[row, col]++;
            }
            while (true) //down
            {
                row++;
                if (row >= N)
                {
                    row = ROW;
                    col = COL;
                    break;
                }
                matrix[row, col]++;
            }
        }
    }
}
