using System;

namespace people
{
    public class Job
    {
        public string position;
        public double salary;
        public string employer;
        public string workAdress;

        public Job(string position, double salary, string employer, string workAdress)
        {
            this.position = position;
            this.salary = salary;
            this.employer = employer;
            this.workAdress = workAdress;
        }
    }
}
