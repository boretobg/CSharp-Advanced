using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
                queue.Enqueue(input[i]);
            }

            for (int i = 0; i < stack.Count - 1 / 2; i++)
            {
                if (stack.Peek() == '}' && queue.Dequeue() == '{')
                {
                    stack.Pop();
                    continue;
                }
                else if (stack.Peek() == ']' && queue.Dequeue() == '[')
                {
                    stack.Pop();
                    continue;
                }
                else if (stack.Peek() == ')' && queue.Dequeue() == '(')
                {
                    stack.Pop();
                    continue;
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
                Console.WriteLine("YES");
           
        }
    }
}
