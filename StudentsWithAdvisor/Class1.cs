using StudentNamespace;
using TeacherNamespace;

namespace StudentsWithAdvisor
{
    public class StudentWithAdvisor : Student
    {
        public Teacher Advisor { get; set; }
    }
}
