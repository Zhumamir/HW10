
using System;
using System.Collections.Generic;

namespace TeacherNamespace
{
    public class Teacher : PersonNamespace.Person
    {
        public List<Student> Students { get; set; }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Students: {Students.Count}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Students: {Students.Count}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Teacher otherTeacher)
            {
                return Name == otherTeacher.Name && Age == otherTeacher.Age;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (Name, Age).GetHashCode();
        }
    }
}
