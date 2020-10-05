using System;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Console.WriteLine($"{Count(nums)}\n{Sum(nums)}");
        }

        static public int Sum(int[] nums)
        {
            return nums.Sum();
        }

        static int Count(int[] nums)
        {
            return nums.Count();
        }
    }
}
