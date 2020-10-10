using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OldestFamilyMember
{
    public class Family
    {
        public List<Person> ListFamily { get; set; }

        public Family(Person person)
        {
            this.ListFamily = person;
        }

        static void AddMember(Person person, List<Person> familyList)
        {
            familyList.Add(person);
        }
        static void GetOldestMember(Person person, List<Person> familyList)
        {
            familyList.Add(person);
        }

        public Family()
        {

        }
    }
}
