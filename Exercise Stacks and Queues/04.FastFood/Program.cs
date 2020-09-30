using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int[] order = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(order);

            Console.WriteLine(queue.Max());

            while (queue.Count > 0)
            {
                if (food >= queue.Peek())
                {
                    food -= queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}
