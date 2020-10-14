using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace OldestFamilyMember
{
    public class Family
    {
        public Family()
        {
            this.ListFamily = new List<Person>();
        }

        public List<Person> ListFamily { get; set; }


        public void AddMember(Person person)
        {
            this.ListFamily.Add(person);
        }

        public Person GetOldestMember()
        {
            Person oldest = new Person();
            int max = int.MinValue;

            foreach (var item in ListFamily)
            {
                if (item.Age > max)
                {
                    max = item.Age;
                    oldest.Age = item.Age;
                    oldest.Name = item.Name;
                }
            }

            return oldest;
        }
    }
}
