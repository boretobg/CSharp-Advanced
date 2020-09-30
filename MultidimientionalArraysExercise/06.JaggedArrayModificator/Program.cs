using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;

namespace _06.JaggedArrayModificator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];

            for (int row = 0; row < jagged.Length; row++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[row] = new int[nums.Length];
                for (int col = 0; col < nums.Length; col++)
                {
                    jagged[row][col] = nums[col];
                }
            }

            for (int row = 0; row < jagged.GetLength(0); row++)
            {

                if (row == jagged.GetLength(0) - 1)
                {
                    break;
                }

                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    if (jagged[row + 1].Length > jagged[row].Length)
                    {
                        for (int col = 0; col < jagged[row + 1].Length; col++)
                        {
                            jagged[row + 1][col] /= 2;
                            if (jagged[row].Length <= col)
                            {
                                continue;
                            }
                            jagged[row][col] /= 2;
                        }
                    }
                    else
                    {
                        for (int col = 0; col < jagged[row].Length; col++)
                        {
                            jagged[row][col] /= 2;
                            if (jagged[row + 1].Length <= col)
                            {
                                continue;
                            }
                            jagged[row + 1][col] /= 2;
                        }
                    }
                }

            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] cmd = input.Split();
                int row = int.Parse(cmd[1]);
                int col = int.Parse(cmd[2]);
                int value = int.Parse(cmd[3]);
                if (cmd[0] == "Add") //{row} {column} {value}
                {
                    if (row < 0)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    if (row < jagged.GetLength(0) && col <= jagged[row].Length)
                    {
                        jagged[row][col] += value;
                    }
                }
                else if (cmd[0] == "Subtract")
                {
                    if (row < 0)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    if (row < jagged.GetLength(0) && col <= jagged[row].Length)
                    {
                        jagged[row][col] -= value;
                    }
                }
                input = Console.ReadLine();
            }

            for (int row = 0; row < jagged.GetLength(0); row++)
            { 
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
