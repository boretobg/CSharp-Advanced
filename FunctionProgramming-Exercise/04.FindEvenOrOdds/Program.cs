using System;
using System.Linq;

namespace _04.FindEvenOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string cmd = Console.ReadLine();

            Predicate<int> predicate = IsEven;
            for (int i = nums[0]; i <= nums[1]; i++)
            {
                bool result = predicate(i);
                if (cmd == "even")
                {
                    if (result)
                    {
                        Console.Write(i + " ");
                    }
                }
                else
                {
                    if (!result)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }

        static bool IsEven(int n)
        {
            if (n % 2  == 0)
            {
                return true;
            }
            return false;
        }
    }
}
