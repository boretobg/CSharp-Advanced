using System;

namespace ListyIteratorExercise
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
                input = Console.ReadLine();
            }
        }
    }
}
