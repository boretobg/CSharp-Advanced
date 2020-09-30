using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>(input);

            foreach (var item in stack)
            {
                Console.Write(item);
            }

        }
    }
}
