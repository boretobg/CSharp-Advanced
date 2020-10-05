﻿using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => x[0] == x.ToUpper()[0]).ToArray();
            Console.WriteLine(string.Join("\n", text));
        }
    }
}
