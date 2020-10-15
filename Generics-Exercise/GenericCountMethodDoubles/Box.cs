using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GenericCountMethodDoubles
{
    public class Box<T> where T : IComparable
    {
        public List<T> List { get; set; }

        public Box(List<T> list)
        {
            this.List = list;
        }

        public int Compare(T element, List<T> list)
        {
            int count = 0;
            foreach (var item in this.List)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
