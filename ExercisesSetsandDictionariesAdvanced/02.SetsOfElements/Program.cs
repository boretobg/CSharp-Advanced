using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var first = new HashSet<int>();
            var second = new HashSet<int>();

            for (int i = 0; i < nums[0]; i++)
            {
                first.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < nums[1]; i++)
            {
                second.Add(int.Parse(Console.ReadLine()));
            }

            var list = second.ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (first.Contains(list[i]))
                {
                    Console.Write(list[i] + " ");
                }
            }
        }
    }
}
