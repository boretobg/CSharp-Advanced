using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                string name = line[0];
                decimal grade = decimal.Parse(line[1]);

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<decimal>();
                }
                students[name].Add(grade);
            }

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value)} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
