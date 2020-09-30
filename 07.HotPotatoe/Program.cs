using System;
using System.Collections.Generic;

namespace _07.HotPotatoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(names);

            int tosses = int.Parse(Console.ReadLine());

            while (queue.Count > 1)
            {
                for (int i = 1; i < tosses; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}
