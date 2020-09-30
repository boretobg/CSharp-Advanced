using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = String.Empty;
            Stack<string> stack = new Stack<string>();

            string temp = text;

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split();
                switch (cmd[0])
                {
                    case "1":
                        text += cmd[1];
                        stack.Push(text);
                        break;
                    case "2":
                        temp = text;
                        int index = int.Parse(cmd[1]);
                        text = text.Reverse().ToString();
                        text.Remove(0, index);
                        text = text.Reverse().ToString();
                        stack.Push(text);
                        break;
                    case "3":
                        int num = int.Parse(cmd[1]);
                        if (text.Length == 0)
                        {
                            Console.WriteLine(text[0]);
                            break;
                        }
                        Console.WriteLine(text[num - 1]);
                        break;
                    case "4":
                        stack.Pop();
                        text = stack.Peek();
                        break;
                }
            }
        }
    }
}
