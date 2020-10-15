using System;
using System.Collections.Generic;

namespace GenericCountMethodDoubles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new List<double>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                list.Add(double.Parse(Console.ReadLine()));
            }

            double element = double.Parse(Console.ReadLine());
            var box = new Box<double>(list);
            Console.WriteLine(box.Compare(element, list));
        }
    }
}
