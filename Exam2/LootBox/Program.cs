using System;
using System.Collections;
using System.Linq;
using System.Runtime.InteropServices;

namespace LootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue firstLootBox = new Queue(input);
            input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack secondLootBox = new Stack(input);

            int sum = 0;

            bool firstBox = false;
            bool secondBox = false;

            while (true)
            {
                if (firstLootBox.Count == 0)
                {
                    firstBox = true;
                    break;
                }
                else if (secondLootBox.Count == 0)
                {
                    secondBox = true;
                    break;
                }
                int first = Convert.ToInt32(firstLootBox.Peek());
                int last = Convert.ToInt32(secondLootBox.Peek());
                if ((first + last) % 2 == 0)
                {
                    sum += (first + last);
                    firstLootBox.Dequeue();
                    secondLootBox.Pop();
                }
                else
                {
                    firstLootBox.Enqueue(secondLootBox.Pop());
                }
            }

            if (firstBox)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (secondBox)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (sum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sum}");
            }
        }
    }
}
