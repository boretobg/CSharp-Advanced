using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _01.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(", ")
                .Select((n) => 
                {
                    return int.Parse(n);
                })
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToArray();

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
