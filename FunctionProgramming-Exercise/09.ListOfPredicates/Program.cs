using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            var targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int, int[], List<int>> func = Calculation;
            var list = func(range, targets);
            Console.WriteLine(string.Join(" ", list));
        }

        static List<int> Calculation(int range, int[] targets)
        {
            var list = new List<int>();
            for (int i = 1; i <= range; i++)
            {
                bool isTrue = false;
                for (int j = 0; j < targets.Length; j++)
                {
                    if (i % targets[j] == 0)
                    {
                        isTrue = true;
                    }
                    else
                    {
                        isTrue = false;
                        break;
                    }
                }

                if (isTrue)
                {
                    list.Add(i);
                }
            }

            return list;
        }
    }
}
