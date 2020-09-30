using System;
using System.Linq;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, 1];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] line = Console.ReadLine().Split("");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            string target = Console.ReadLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 0].Contains(target))
                {
                    Console.WriteLine($"({i}, {matrix[i, 0].IndexOf(target)})");
                    return;
                }
            }
            Console.WriteLine($"{target} does not occur in the matrix");
        }
    }
}
