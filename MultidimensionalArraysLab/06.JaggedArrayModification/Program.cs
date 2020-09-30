using System;
using System.Linq;

namespace _06.JaggedArrayModification
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

            string line = Console.ReadLine();
            while (line != "END")
            {
                string[] cmd = line.Split();
                int row = int.Parse(cmd[1]);
                int col = int.Parse(cmd[2]);
                int value = int.Parse(cmd[3]);
                bool invalid = false;
                if (jagged.Length <= row || row < 0)
                {
                    invalid = true;
                }
               else  if (jagged[row].Length <= col || col < 0)
                {
                    invalid = true;
                }

                if (invalid)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (cmd[0] == "Add")
                    {
                        jagged[row][col] += value;
                    }
                    else if (cmd[0] == "Subtract")
                    {
                        jagged[row][col] -= value;
                    }
                }
                line = Console.ReadLine();
            }

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
