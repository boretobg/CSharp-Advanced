using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.CitiesbyContinentandCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                string continent = line[0];
                string country = line[1];
                string city = line[2];

                if (!continents.ContainsKey(continent))
                {
                    continents[continent] = new Dictionary<string, List<string>>();
                }
                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent][country] = new List<string>();
                }
                continents[continent][country].Add(city);
            }

            var list = continents.ToList();
            int count = 0;
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var item2 in list[count].Value)
                {
                    Console.WriteLine($"  {item2.Key} -> {string.Join(", ", item2.Value)}");
                }
                count++;
            }
                
        }
    }
}
