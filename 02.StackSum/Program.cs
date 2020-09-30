using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(nums);

            string input = Console.ReadLine().ToLower();
            while (input != "end")
            {
                string[] cmd = input.Split();
                switch (cmd[0])
                {
                   case "add":
                        stack.Push(int.Parse(cmd[1]));
                        stack.Push(int.Parse(cmd[2]));
                        break;
                    case "remove":
                        if (int.Parse(cmd[1]) < stack.Count)
                        {
                            for (int i = 0; i < int.Parse(cmd[1]); i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                }
                input = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
