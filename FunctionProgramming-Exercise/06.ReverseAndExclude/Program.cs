using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int divider = int.Parse(Console.ReadLine());

            Func<int[], int, List<int>> func = Reverser;
            var reversed = func(nums, divider);

            Action<List<int>, int> action = Divider;
            action(reversed, divider);
        }

        static List<int> Reverser(int[] nums, int divider)
        {
            var reversed = new List<int>();
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                reversed.Add(nums[i]);
            }
            return reversed;
        }
        static void Divider(List<int> reversed, int divider)
        {
            for (int i = 0; i < reversed.Count; i++)
            {
                if (reversed[i] % divider != 0)
                {
                    Console.Write(reversed[i] + " ");
                }
            }
        }
    }
}
