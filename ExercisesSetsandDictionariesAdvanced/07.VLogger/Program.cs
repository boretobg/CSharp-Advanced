using System;
using System.Collections.Generic;

namespace _07.VLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vLogger = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();
            while (input != "Statistic")
            {
                string[] splitted = input.Split();
                string name = splitted[0];
                string cmd = splitted[1];

                if (cmd == "joined")
                {
                    if (!vLogger.ContainsKey(name))
                    {
                        vLogger.Add(name, new Dictionary<string, int>());
                    }
                }
                else if (cmd == "followed")
                {
                    string secondName = splitted[2];

                    if (vLogger.ContainsKey(secondName))
                    {
                        vLogger[secondName].Add(name, 0);
                        vLogger[name]
                    }

                    if (name == secondName)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }


                input = Console.ReadLine();
            }

        }
    }
}
