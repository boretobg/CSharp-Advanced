using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();
            while (input != "Party!")
            {
                Action<List<string>, string> action = Action;
                action(names, input);
                input = Console.ReadLine();
            }

            if (names.Count == 0)
            {
                Console.WriteLine($"Nobody is going to the party!");
                return;
            }
            Console.WriteLine($"{string.Join(", ", names)} are going to the party!");

        }

        static void Action(List<string> names, string input)
        {
            var cmd = input.Split();
            if (input.Contains("Remove"))
            {
                if (input.Contains("StartsWith"))
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if(names[i].StartsWith(cmd[2]))
                        {
                            names.Remove(names[i]);
                        }
                    }
                }
                else if (input.Contains("EndsWith"))
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (names[i].EndsWith(cmd[2]))
                        {
                            names.Remove(names[i]);
                        }
                    }
                }
                else if (input.Contains("Length"))
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (names[i].Length == int.Parse(cmd[2]))
                        {
                            names.Remove(names[i]);
                        }
                    }
                }
            }
            else if (input.Contains("Double"))
            {
                if (input.Contains("StartsWith"))
                {
                    int count = 0;
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (names[i].StartsWith(cmd[2]))
                        {
                            names.Insert(0, names[i]);
                            i++;
                        }
                    }
                }
                else if (input.Contains("EndsWith"))
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (names[i].EndsWith(cmd[2]))
                        {
                            names.Insert(0, names[i]);
                            i++;
                        }
                    }
                }
                else if (input.Contains("Length"))
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (names[i].Length == int.Parse(cmd[2]))
                        {
                            names.Insert(0, names[i]);
                            i++;
                        }
                    }
                }
            }

        }
    }
}
