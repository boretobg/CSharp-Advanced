using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select((n) =>
                {
                    double x = double.Parse(n) + (double.Parse(n) * 0.2);
                    return $"{x:f2}";
                })
                .ToArray();

            Console.WriteLine(string.Join("\n", nums));
        }
    }
}
