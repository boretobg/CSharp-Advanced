using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(nums[i]);
            }
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }
            else
            {
                int min = int.MaxValue;
                int count = stack.Count;
                for (int i = 0; i < count; i++)
                {
                    if (stack.Peek() < min)
                    {
                        min = stack.Peek();
                    }
                    stack.Pop();
                }
                Console.WriteLine(min);
            }
        }
    }
}
