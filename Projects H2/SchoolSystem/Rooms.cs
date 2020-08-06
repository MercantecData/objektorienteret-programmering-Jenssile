using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem
{
    class Rooms
    {
        private string name;
        private Courses course;

        public Rooms(string name, Courses course)
        {
            this.name = name;
            this.course = course;
        }

        public void AddCourse(Courses courses) { course = courses; }
    }
}
