using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNamespace
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Person otherPerson)
            {
                return Name == otherPerson.Name && Age == otherPerson.Age;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (Name, Age).GetHashCode();
        }

        public static bool operator ==(Person person1, Person person2)
        {
            if (object.ReferenceEquals(person1, person2))
                return true;

            if (person1 is null || person2 is null)
                return false;

            return person1.Equals(person2);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }
    }
}
