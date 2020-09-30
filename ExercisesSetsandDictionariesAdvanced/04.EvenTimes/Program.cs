using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var elements = new HashSet<int>();

            int target = 0;
            int count = 1;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (elements.Contains(num))
                {
                    target = num;
                    count++;
                }
                elements.Add(num);
            }
            if (count % 2 == 0)
            {
                Console.WriteLine(target);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
