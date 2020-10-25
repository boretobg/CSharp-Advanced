using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Stack<int> tasks = new Stack<int>(n);
            n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> threads = new Queue<int>(n);

            int task = int.Parse(Console.ReadLine());

            var killer = 0;
            bool wasKilled = false;
            while (!wasKilled)
            {

                var lastTask = Convert.ToInt32(tasks.Peek());
                var firstThread = Convert.ToInt32(threads.Peek());

                if (lastTask == task)
                {
                    killer = firstThread;
                    wasKilled = true;
                    break;
                }
                if (firstThread >= lastTask)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else if (firstThread < lastTask)
                {
                    threads.Dequeue();
                }
            }
            
            Console.WriteLine($"Thread with value {killer} killed task {task}");
            Console.WriteLine(string.Join(" ", threads));
        }
    }
}
