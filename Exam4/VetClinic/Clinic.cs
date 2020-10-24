using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        public List<Pet> data;
        public int Capacity { get; set; }
        public int Count { get { return this.data.Count(); } }

        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.data = new List<Pet>();
        }

        public void Add(Pet pet)
        {
            if (Count < Capacity)
            {
                data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            Pet toRemove = data.FirstOrDefault(p => p.Name == name);
            if (toRemove != null)
            {
                data.Remove(toRemove);
                return true;
            }
            return false;
        }

        public Pet GetPet(string name, string owner)
        {
            return data.FirstOrDefault(p => p.Name == name && p.Owner == owner);
        }

        public Pet GetOldestPet()
        {
            int oldest = data.Max(p => p.Age);
            return data.FirstOrDefault(p => p.Age == oldest);
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (var pet in data)
            {
                sb.AppendLine(pet.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
