using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class BoxInt<T>
    {
        public List<T> BoxItem;

        public BoxInt()
        {
            this.BoxItem = new List<T>();
        }
        public BoxInt(T item)
        {
            this.BoxItem.Add(item);
        }
        public void SwapMe(int first, int second)
        {
            if (first == second)
            {

            }
            else if (first < second)
            {
                var temp = BoxItem[first];
                BoxItem.RemoveAt(first);
                BoxItem.Insert(first, BoxItem[second - 1]);
                BoxItem.RemoveAt(second);
                BoxItem.Insert(second, temp);
            }
            else
            {
                var temp = BoxItem[second];
                BoxItem.RemoveAt(second);
                BoxItem.Insert(second, BoxItem[first - 1]);
                BoxItem.RemoveAt(first);
                BoxItem.Insert(first, temp);
            }
        }
    }
}
