using People;
using System;
using System.Collections.Generic;

namespace Register
{
    public class Register
    {
        private List<Person> peoples = new List<Person>();

        public Register(List<Person> peoples)
        {
            this.peoples = peoples;
        }
    }
}
