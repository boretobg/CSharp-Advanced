using GenericBoxOfString;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SwapMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                box.BoxItem.Add(Console.ReadLine());
            }

            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.SwapMe(nums[0], nums[1]);
            for (int i = 0; i < box.BoxItem.Count; i++)
            {
                Console.WriteLine($"{box.BoxItem[i].GetType()}: {box.BoxItem[i]}");
            }
        }
    }
}
