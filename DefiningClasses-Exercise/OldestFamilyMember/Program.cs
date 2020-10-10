using System;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Bore";
            person.Age = 18;

            Person person2 = new Person();
            person.Name = "Moras";
            person.Age = 8;

            Family family = new Family();
            family.ListFamily(person);
            
        }
    }
}
