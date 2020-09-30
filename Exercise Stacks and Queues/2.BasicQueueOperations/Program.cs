using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int n = input[0];
                int s = input[1];
                int x = input[2];

                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Queue<int> queue = new Queue<int>();

                for (int i = 0; i < n; i++)
                {
                    queue.Enqueue(nums[i]);
                }
                for (int i = 0; i < s; i++)
                {
                    queue.Dequeue();
                }
                if (queue.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else if (queue.Count == 0)
                {
                    Console.WriteLine("0");
                    return;
                }
                else
                {
                    int min = int.MaxValue;
                    int count = queue.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (queue.Peek() < min)
                        {
                            min = queue.Peek();
                        }
                        queue.Dequeue();
                    }
                    Console.WriteLine(min);
                }
            }
        }
    }
}
