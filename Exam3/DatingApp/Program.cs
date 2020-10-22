using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Intrinsics.X86;

namespace DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> males = new Stack<int>(n);
            n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> females = new Queue<int>(n);

            int matches = 0;

            while (males.Count != 0 && females.Count != 0)
            {
                var lastMale = Convert.ToInt32(males.Peek());
                var firstFemale = Convert.ToInt32(females.Peek());

                if (lastMale <= 0)
                {
                    males.Pop();
                    continue;
                }
                if (firstFemale <= 0)
                {
                    females.Dequeue();
                    continue;
                }

                if (lastMale % 25 == 0)
                {
                    males.Pop();
                    males.Pop();
                    continue;
                }
                if (firstFemale % 25 == 0)
                {
                    females.Dequeue();
                    females.Dequeue();
                    continue;
                }


                if (lastMale == firstFemale)
                {
                    matches++;
                    males.Pop();
                    females.Dequeue();
                }
                else
                {
                    females.Dequeue();
                    males.Pop();
                    lastMale -= 2;
                    males.Push(lastMale);
                }
            }

            Console.WriteLine($"Matches: {matches}");
            if (males.Count == 0)
            {
                Console.WriteLine("Males left: none");
            }
            else
            {
                Console.WriteLine($"Males left: {string.Join(", ", males)}");
            }

            if (females.Count == 0)
            {
                Console.WriteLine("Females left: none");
            }
            else
            {
                Console.WriteLine($"Females left: {string.Join(", ", females)}");
            }
        }
    }
}
