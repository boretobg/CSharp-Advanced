using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Reverse().ToArray();
            Stack<string> stack = new Stack<string>(input);


            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string symbol = stack.Pop();
                int second = int.Parse(stack.Pop());

                if (symbol == "+")
                {
                    stack.Push((first + second).ToString());
                }
                else
                {
                    stack.Push((first - second).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
