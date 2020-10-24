using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Stack<int> lillies = new Stack<int>(n);
            n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Queue<int> roses = new Queue<int>(n);

            int wreaths = 0;
            int forLater = 0;

            while (roses.Count != 0 && lillies.Count != 0)
            {
                var firstLillie = Convert.ToInt32(lillies.Peek());
                var lastRose = Convert.ToInt32(roses.Peek());
                int sum = firstLillie + lastRose;
                if (sum == 15)
                {
                    wreaths++;
                    lillies.Pop();
                    roses.Dequeue();
                }
                else if (sum > 15)
                {
                    var temp = Convert.ToInt32(lillies.Peek());
                    temp -= 2;
                    lillies.Pop();
                    lillies.Push(temp);
                }
                else if (sum < 15)
                {
                    forLater += sum;
                    roses.Dequeue();
                    lillies.Pop();
                }
            }

            wreaths += forLater / 15;

            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!" );
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {Math.Abs(5 - wreaths)} wreaths more!");
            }
        }
    }
}
