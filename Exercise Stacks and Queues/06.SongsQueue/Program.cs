using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(songs);

            string command = string.Empty;
            while (queue.Count > 0)
            {
                command = Console.ReadLine();
                string[] cmd = command.Split();
                string song = string.Empty;

                if (cmd.Contains("Play"))
                {
                    queue.Dequeue();
                }
                else if (cmd.Contains("Add"))
                {
                    for (int i = 1; i < cmd.Length; i++)
                    {
                        if (i == cmd.Length - 1)
                        {
                            song += cmd[i];
                            break;
                        }
                        song += cmd[i] + " ";
                    }

                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
                else if (cmd.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }

            Console.WriteLine("No more songs!");

        }
    }
}
