using ListyIteratorExercise;
using System;
using System.Collections.Generic;

namespace Collection
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = new ListyIterator<string>();

            string[] create = Console.ReadLine().Split();
            listyIterator.Create(create);

            string input = Console.ReadLine();
            while (input != "END")
            {
                if (input == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                else if (input == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }
                else if (input == "Print")
                {
                    listyIterator.Print();
                }
                else if (input == "PrintAll")
                {
                    foreach (var item in listyIterator)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                input = Console.ReadLine();
            }
        }
    }
}
