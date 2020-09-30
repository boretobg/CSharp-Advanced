using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(clothes);

            int box = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 1;

            while (stack.Count > 0) //16
            {
                if (sum < box)
                {
                    sum += stack.Pop();
                }
                if (sum > box)
                {
                    count++;
                    sum -= box;
                }
                if (sum == box)
                {
                    count++;
                    sum = 0;
                }
            }

            if (sum < box)
            {
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
