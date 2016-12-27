using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractise
{
    class Student
    {
        private readonly List<Student> _students;
        public Student()
        {
            _students = new List<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public List<Student> GetStudentList()
        {
            _students.Add(new Student() { Id = 1, Name = "rasel", Age = 25 });
            _students.Add(new Student() { Id = 2, Name = "arnold", Age = 37 });
            _students.Add(new Student() { Id = 3, Name = "crow", Age = 50 });
            _students.Add(new Student() { Id = 4, Name = "Andrew", Age = 32 });
            _students.Add(new Student() { Id = 5, Name = "Expoler", Age = 16 });

            return _students;
        }

        public void AddStudent(Student stdObject)
        {
            _students.Add(stdObject);
        }



    }
}
