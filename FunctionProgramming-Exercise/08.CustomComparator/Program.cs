using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Action<int[]> action = CustomSeparator;
            action(nums);
        }

        static void CustomSeparator(int[] nums)
        {
            var list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                Predicate<int> isEven = IsEven;
                if (isEven(nums[i]))
                {
                    list.Add(nums[i]);
                }
            }
            list.Sort();

            var list2 = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                Predicate<int> isOdd = IsOdd;
                if (isOdd(nums[i]))
                {
                    list2.Add(nums[i]);
                }
            }
            list2.Sort();

            Console.WriteLine($"{string.Join(" ", list)} {string.Join(" ", list2)}");
        }

        static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }
        static bool IsOdd(int num)
        {
            if (num % 2 == 1 || num % 2 == -1)
            {
                return true;
            }
            return false;
        }
    }
}
