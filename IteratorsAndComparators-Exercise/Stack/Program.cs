using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace ManualStack
{
    public class StartUp
    {
        static void Main(string[] args) //NOT A RIGHT SOLUTION
        {
            Stack stack = new Stack();
            char[] splitter = new char[2] { ' ', ',' };
            var cmd = Console.ReadLine().Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            var nums = new int[cmd.Length - 1];
            for (int i = 1; i < cmd.Length; i++)
            {
                nums[i - 1] = int.Parse(cmd[i]);
            }
            stack.Push(nums);

            string input = Console.ReadLine();
            while (input != "END")
            {
                if (input.Contains("Push"))
                {
                    string[] line = input.Split();
                    stack.Push(new int[] { int.Parse(line[1]) });
                }
                else if (input.Contains("Pop"))
                {
                    stack.Pop();
                }
                input = Console.ReadLine();
            }

            stack.StackList.Reverse();
            Console.WriteLine(string.Join("\n", stack.StackList)) ;
            Console.WriteLine(string.Join("\n", stack.StackList)) ;
        }
 
}
}
