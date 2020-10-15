using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<T>
    {
        public T Item1 { get; set; }
        public T Item2 { get; set; }

        public Tuple(T item1, T item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public Tuple()
        {

        }
    }
}
