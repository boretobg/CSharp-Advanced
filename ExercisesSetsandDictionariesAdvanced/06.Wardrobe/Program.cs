using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] color = Console.ReadLine().Split(" -> ");
                string[] cloth = color[1].Split(",");

                if (!wardrobe.ContainsKey(color[0]))
                {
                    wardrobe.Add(color[0], new Dictionary<string, int>());
                }

                for (int j = 0; j < cloth.Length; j++)
                {
                    if (!wardrobe[color[0]].ContainsKey(cloth[j]))
                    {
                        wardrobe[color[0]].Add(cloth[j], 0);
                    }
                    wardrobe[color[0]][cloth[j]]++;
                }
            }

            string[] cmd = Console.ReadLine().Split();
            string targetColor = cmd[0];
            string targetCloth = cmd[1];

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var item2 in wardrobe[item.Key])
                {
                    Console.Write($"* {item2.Key} - {item2.Value}");
                    if (item.Key == targetColor && item2.Key == targetCloth)
                    {
                        Console.WriteLine(" (found!)");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
