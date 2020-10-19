using System;
using System.Collections.Generic;
using System.Text;

namespace ListyIteratorExercise
{
    public class ListyIterator<T>
    {
        public List<T> List { get; set; }
        public int Count = 0;

        public ListyIterator()
        {
            List = new List<T>();
        }
        public void Create(T[] elements)
        {
            for (int i = 1; i < elements.Length; i++)
            {
                List.Add(elements[i]);
            }
        }
        public bool Move()
        {
            if (Count + 1 < List.Count)
            {
                Count++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            if (Count + 1 < List.Count)
            {
                return true;
            }
            return false;
        }
        public void Print()
        {
            if (List.Count == 0)
            {
                throw new System.ArgumentException("Invalid Operation!");
            }
            Console.WriteLine(List[Count]);
        }
    }
}
