using System;

namespace Jobs
{
    public class hJob // is used in person.cs
    {
        public string position;
        public double salary;
        public string employer;
        public string workAdress;

        public hJob(string position, double salary, string employer, string workAdress)
        {
            this.position = position;
            this.salary = salary;
            this.employer = employer;
            this.workAdress = workAdress;
        }
    }
}
