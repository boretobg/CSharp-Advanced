using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        public T BoxItem;

        public Box(T item)
        {
            this.BoxItem = item;
        }
        public override string ToString()
        {
            var output = $"{BoxItem.GetType()}: {BoxItem}";
            return output;
        }
    }
}
