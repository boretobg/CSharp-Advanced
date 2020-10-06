using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static int MinNum(int[] nums)
        {
            return nums.Min();
        }

        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> functiom = MinNum;
            int min = functiom(nums);

            Console.WriteLine(min);
        }
    }
}
