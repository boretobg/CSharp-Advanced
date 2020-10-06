using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string input = Console.ReadLine();
            while (input != "end")
            {
                Action<int[], string> action = NumAction;
                action(nums, input);
                input = Console.ReadLine();
            }
        }

        static void NumAction(int[] nums, string input)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (input == "add")
                {
                    nums[i]++;
                }
                else if (input == "multiply")
                {
                    nums[i] *= 2;
                }
                else if (input == "subtract")
                {
                    nums[i]--;
                }
                else if (input == "print")
                {
                    Console.WriteLine(string.Join(" ", nums));
                    return;
                }
            }
        }
    }
}
