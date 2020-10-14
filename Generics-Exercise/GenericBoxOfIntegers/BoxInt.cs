using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfIntegers
{
    public class BoxInt<T>
    {
        public T Item;

        public BoxInt(T item)
        {
            this.Item = item;
        }
        public string ToInt()
        {
            return $"{Item.GetType()}: {Item}";
        }
    }
}
