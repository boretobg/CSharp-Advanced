using System;

namespace GenericBoxOfIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                BoxInt<int> box = new BoxInt<int>(int.Parse(Console.ReadLine()));
                Console.WriteLine(box.ToInt());
            }
        }
    }
}
