using System;
using System.Collections.Generic;
using System.Globalization;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            Queue<string> queue = new Queue<string>();

            string car = string.Empty;
            while (car != "end")
            {
                car = Console.ReadLine();

                bool wasGreen = false;
                if (car == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        count++;
                    }
                    wasGreen = true;
                }

                if (!wasGreen)
                {
                    queue.Enqueue(car);
                }
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
