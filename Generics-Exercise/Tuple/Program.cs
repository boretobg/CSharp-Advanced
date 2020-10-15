using System;
using System.Linq;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var tuple = new Tuple<string>(input[0] + " " + input[1], input[2]);
            Console.WriteLine($"{tuple.Item1} -> {tuple.Item2}");

            input = Console.ReadLine().Split();
            tuple = new Tuple<string>(input[0], input[1]);
            Console.WriteLine($"{tuple.Item1} -> {tuple.Item2}");

            input = Console.ReadLine().Split();
            tuple = new Tuple<string>(input[0], input[1]);
            Console.WriteLine($"{tuple.Item1} -> {tuple.Item2}");
        }
    }
}
