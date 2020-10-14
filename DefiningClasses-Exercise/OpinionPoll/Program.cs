using System;
using System.Collections.Generic;
using System.Linq;

namespace OpinionPoll
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();
                var name = line[0];
                var age = int.Parse(line[1]);

                Person person = new Person(name, age);
                list.Add(person);
            }

            var output = list.OrderBy(x => x.Name);

            foreach (var item in output)
            {
                if (item.Age > 30)
                {
                    Console.WriteLine($"{item.Name} - {item.Age}");
                }
            }
        }
    }
}
