using System;

namespace people
{
    public class Job
    {
        private string position;
        private double salary;
        private string employer;
        private string workAdress;

        public Job(string position, double salary, string employer, string workAdress)
        {
            this.position = position;
            this.salary = salary;
            this.employer = employer;
            this.workAdress = workAdress;
        }
    }
}
