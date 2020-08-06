using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem
{
    class Employe
    {
        private string name;
        private int age;
        private decimal salary;
        private bool hasbeenpayed;

        public Employe(string name, int age, decimal salary, bool hasbeenpayed)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
            this.hasbeenpayed = hasbeenpayed;
        }

        private void Pay() { hasbeenpayed = true; }
    }
}
