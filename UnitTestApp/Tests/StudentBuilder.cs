using App;

namespace Tests
{
    internal class StudentBuilder
    {
        private readonly Student student;

        public StudentBuilder()
        {
            student = new Student();
        }

        public StudentBuilder AddAge(int age) 
        {
            student.Age = age;
            return this;
        }

        public StudentBuilder AddGrade(int grade)
        {
            student.Grade = grade;
            return this;
        }

        public Student Build()
        {
            return student;
        }
    }
}
