using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem
{
    class Courses
    {
        private string coursename;
        private Employe teacher;
        private List<Student> students;
        private string description;

        public Courses(string coursename, Employe teacher, List<Student> students, string description)
        {
            this.coursename = coursename;
            this.teacher = teacher;
            this.students = students;
            this.description = description;
        }

        public void AddStudent(Student student) { students.Add(student); }
        public void AddTeacher(Employe employe) { teacher = employe; }
    }
}
