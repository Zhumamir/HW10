using PersonNamespace;
using StudentNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherNamespace;

namespace HW10
{
    class Program
    {
        static void Main()
        {
            var person1 = new Person { Name = "John", Age = 30 };
            var student1 = new Student { Name = "Alice", Age = 20, Course = 2 };
            var teacher1 = new Teacher { Name = "Mr. Smith", Age = 45 };

            teacher1.Students = new List<Student> { student1 };
            student1.Advisor = teacher1;

            Person[] people = new Person[] { person1, student1, teacher1 };

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }

            int personCount = people.Count(p => p is Person);
            int studentCount = people.Count(p => p is Student);
            int teacherCount = people.Count(p => p is Teacher);

            Console.WriteLine($"Person count: {personCount}");
            Console.WriteLine($"Student count: {studentCount}");
            Console.WriteLine($"Teacher count: {teacherCount}");

            foreach (var person in people)
            {
                if (person is Student student)
                {
                    student.Course++;
                }
            }
        }
    }
}
