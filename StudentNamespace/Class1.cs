using PersonNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TeacherNamespace;

namespace StudentNamespace
{
    public class Student : PersonNamespace.Person
    {
        public Teacher Advisor { get; set; }
        public int Course { get; set; }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Course: {Course}, Advisor: {Advisor.Name}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Course: {Course}, Advisor: {Advisor.Name}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Student otherStudent)
            {
                return Name == otherStudent.Name && Age == otherStudent.Age &&
                       Course == otherStudent.Course && Advisor == otherStudent.Advisor;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (Name, Age, Course, Advisor).GetHashCode();
        }
    }

}
