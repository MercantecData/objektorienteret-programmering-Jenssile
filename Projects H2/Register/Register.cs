using People;
using System;
using System.Collections.Generic;

namespace Register
{
    public class RegisterClass
    {
        public List<Person> peoples = new List<Person>();

        public RegisterClass(List<Person> peoples)
        {
            this.peoples = peoples;
        }

        public void AddToList(Person person)
        {
            peoples.Add(person);
        }

        public List<Person> GetList()
        {
            return peoples;
        }
    }
}
