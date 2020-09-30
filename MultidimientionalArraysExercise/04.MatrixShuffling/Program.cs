using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] text = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = text[col];
                }
            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] cmd = input.Split();
                if (cmd.Length > 5 || cmd.Length < 5)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }

                int row1 = int.Parse(cmd[1]);
                int col1 = int.Parse(cmd[2]);
                int row2 = int.Parse(cmd[3]);
                int col2 = int.Parse(cmd[4]);


                if (cmd[0] == "swap")
                {
                    if (row1 > matrix.GetLength(0) || col1 > matrix.GetLength(1))
                    {
                        Console.WriteLine("Invalid input!");
                        input = Console.ReadLine();
                        continue;
                    }

                    string temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
