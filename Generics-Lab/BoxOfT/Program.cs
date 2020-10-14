using System;
using System.Collections.Generic;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);
            box.Add(4);
            Console.WriteLine(box.Remove());
            box.Add(5);
            box.Add(6);
            Console.WriteLine(box.Remove());
            Console.WriteLine(box.Count);
        }
    }

    public class Box<T>
    {
        public List<T> BoxList { get; set; }
        public int Count { get; set; }

        public Box()
        {
            this.BoxList = new List<T>();
        }
        public void Add(T element)
        {
            this.BoxList.Add(element);
            this.Count++;
        }

        public T Remove()
        {
            T n = BoxList[BoxList.Count - 1];
            this.BoxList.RemoveAt(BoxList.Count - 1);
            this.Count--;
            return n;
        }
    }
}
