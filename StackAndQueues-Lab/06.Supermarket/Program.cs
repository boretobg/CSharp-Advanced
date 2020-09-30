using System;
using System.Collections;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string name = Console.ReadLine();
            while (name != "End")
            {
                bool hasPaid = false;
                if (name == "Paid")
                {
                    int count = queue.Count;
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                    hasPaid = true;
                }

                if (!hasPaid)
                {
                    queue.Enqueue(name);
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
