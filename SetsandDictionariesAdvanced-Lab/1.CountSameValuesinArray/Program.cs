using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.CountSameValuesinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> dic = new Dictionary<double, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]]++;
                }
                else
                {
                    dic[nums[i]] = 1;
                }
            }

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
