using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new List<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }

            string element = Console.ReadLine();
            var box = new Box<string>(list);
            Console.WriteLine(box.Compare(element, list));
        }
    }
}
