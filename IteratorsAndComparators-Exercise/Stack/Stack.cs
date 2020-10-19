using System;
using System.Collections.Generic;
using System.Text;

namespace ManualStack
{
    public class Stack
    {
         public List<int> StackList { get; set; }

        public Stack()
        {
            this.StackList = new List<int>();
        }

        public void Push(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                StackList.Add(nums[i]);
            }
        }

        public void Pop()
        {
            if (StackList.Count == 0)
            {
                Console.WriteLine("No elements");
                return;
            }
            StackList.RemoveAt(StackList.Count - 1);
        }
    }
}
