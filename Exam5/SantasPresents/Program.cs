using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.WebSockets;
using System.Numerics;

namespace SantasPresents
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> materials = new Stack<int>(n);
            n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> values = new Queue<int>(n);

            int doll = 0;
            int train = 0;
            int bear = 0;
            int bicycle = 0;

            while (materials.Count != 0 && values.Count != 0)
            {
                bool present = false;
                var lastMaterial = Convert.ToInt32(materials.Peek());
                var firstValue = Convert.ToInt32(values.Peek());
                var multiplication = lastMaterial * firstValue;

                if (multiplication == 150)
                {
                    doll++;
                    present = true;
                }
                else if (multiplication == 250)
                {
                    train++;
                    present = true;
                }
                else if (multiplication == 300)
                {
                    bear++;
                    present = true;
                }
                else if (multiplication == 400)
                {
                    bicycle++;
                    present = true;
                }

                if (present)
                {
                    materials.Pop();
                    values.Dequeue();
                    continue;
                }

                if (multiplication < 0)
                {
                    materials.Pop();
                    materials.Push(lastMaterial + firstValue);
                    values.Dequeue();
                }
                else if (multiplication > 0)
                {
                    values.Dequeue();
                    int temp = materials.Pop();
                    materials.Push(temp + 15);
                }

                if (lastMaterial == 0)
                {
                    materials.Pop();
                }
                else if (firstValue == 0)
                {
                    values.Dequeue();
                }
            }

            if ((doll > 0 && train > 0) || (bear > 0 && bicycle > 0))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if (materials.Count > 0)
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materials)}");
            }
            else if (values.Count > 0)
            {
                Console.WriteLine($"Magic left: {string.Join(", ", values)}");
            }

            if (bicycle > 0)
            {
                Console.WriteLine($"Bicycle: {bicycle}");
            }
            if (doll > 0)
            {
                Console.WriteLine($"Doll: {doll}");
            }
            if (bear > 0)
            {
                Console.WriteLine($"Teddy bear: {bear}");
            }
            if (train > 0)
            {
                Console.WriteLine($"Wooden train: {train}");
            }
        }
    }
}
