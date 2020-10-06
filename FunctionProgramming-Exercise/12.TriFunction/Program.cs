using System;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            for (int i = 0; i < names.Length; i++)
            {
                Func<int, string[], int, string> action = RightName;
                string temp = action(target, names, i);
                if (temp != string.Empty)
                {
                    Console.WriteLine(temp);
                }
            }

        }

        static string RightName(int target, string[] names, int i)
        {
            int sum = 0;
            for (int j = 0; j < names[i].Length; j++)
            {
                sum += names[i][j];
            }

            if (sum >= target)
            {
                return names[i];
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
