using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace Christmas
{
    public class Bag
    {
        public List<Present> data;
        public string Color { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return data.Count(); } }

        public Bag(string color, int capacity)
        {
            this.Color = color;
            this.Capacity = capacity;
            this.data = new List<Present>();
        }

        public void Add(Present present)
        {
            if (Count < Capacity)
            {
                data.Add(present);
            }
        }

        public bool Remove(string name)
        {
            var toRemove = data.FirstOrDefault(p => p.Name == name);
            if (toRemove != null)
            {
                data.Remove(toRemove);
                return true;
            }
            return false;
        }

        public Present GetHeaviestPresent()
        {
            var target = data.Max(p => p.Weight);
            Present heaviest = data.FirstOrDefault(p => p.Weight == target);
            return data.FirstOrDefault(p => p.Weight == target);
        }

        public Present GetPresent(string name)
        {
            return data.FirstOrDefault(p => p.Name == name);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} bag contains:");
            foreach (var present in data)
            {
                sb.AppendLine(present.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
