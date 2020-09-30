using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindows = int.Parse(Console.ReadLine());
            int n = greenLight + freeWindows;


            Queue<string> queue = new Queue<string>();
            int count = 0;
            bool success = true;
            char index = ' ';
            string car = "";
            string cmd = Console.ReadLine();
            while (cmd != "END")
            {
                bool done = false;
                if (cmd == "green")
                {
                    string tempCar = queue.Peek();
                    car = tempCar;
                    for (int i = 0; i < greenLight; i++)
                    {
                        if (tempCar.Length == 0)
                        {
                            queue.Dequeue();
                            count++;
                            if (queue.Count == 0)
                            {
                                done = true;
                                break;
                            }
                            tempCar = queue.Peek();
                        }
                        tempCar = tempCar.Remove(0, 1);
                    }

                    if (!done)
                    {
                        if (tempCar.Length <= freeWindows)
                        {
                            queue.Dequeue();
                            count++;
                        }
                        else if (tempCar.Length > freeWindows)
                        {
                           
                            for (int i = 0; i < freeWindows; i++)
                            {
                                tempCar = tempCar.Remove(0, 1);
                            }
                            index = tempCar.ElementAt(0);
                            success = false;
                        }
                    }
                    
                }
                else
                {
                    queue.Enqueue(cmd);
                }
                cmd = Console.ReadLine();
            }

            if (success)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{count} total cars passed the crossroads.");
            }
            else
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{car} was hit at {index}.");
            }
        }
    }
}
