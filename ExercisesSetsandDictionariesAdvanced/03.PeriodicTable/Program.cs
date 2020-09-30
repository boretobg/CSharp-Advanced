using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var elements = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                for (int j = 0; j < line.Length; j++)
                {
                    elements.Add(line[j]);
                }
            }

            var list = elements.ToList();
            list.Sort();

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
