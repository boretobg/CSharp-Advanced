using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        public List<Rabbit> data;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return this.data.Count(); } }

        public Cage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Rabbit>();
        }

        public void Add(Rabbit rabbit)
        {
            if (Count < Capacity)
            {
                data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            Rabbit toRemove = data.FirstOrDefault(r => r.Name == name);
            if (toRemove != null)
            {
                if (data.Contains(toRemove))
                {
                    data.Remove(toRemove);
                    return true;
                }
            }
            return false;
        }

        public void RemoveSpecies(string species)
        {
            data.RemoveAll(r => r.Species == species);
        }

        public Rabbit SellRabbit(string name)
        {
            Rabbit toSell = data.FirstOrDefault(r => r.Name == name);
            toSell.Available = false;
            return toSell;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            var list = new List<Rabbit>();
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Species == species)
                {
                    data[i].Available = false;
                    list.Add(data[i]);
                }
            }
            Rabbit[] array = list.ToArray();
            return array;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {Name}:");
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Available == true)
                {
                    sb.AppendLine(data[i].ToString());
                }
            }
            return sb.ToString().Trim();
        }
    }
}
