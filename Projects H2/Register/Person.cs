using people;
using System.Runtime.InteropServices;

namespace People
{
    public class Person
    {
        public string name;
        public int age;
        public int personNr;
        public string adress;
        public Job job;

        public Person(string name, int age, int personNr, string adress, string position, double salary, string employer, string workAdress)
        {
            this.name = name;
            this.age = age;
            this.personNr = personNr;
            this.adress = adress;
            this.job = new Job(position, salary, employer, workAdress);
        }
    }
}