using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();//1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }

                if (input[i] == ')')
                {
                    int index = stack.Pop();
                    for (int j = index; j < i + 1; j++)
                    {
                        Console.Write(input[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
