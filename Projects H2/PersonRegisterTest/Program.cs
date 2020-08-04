using People;
using System;
using System.Collections.Generic;

namespace PersonRegisterTest
{
    class Program
    {
        static void Main()
        {
            List<Person> peoples = new List<Person>
            {
                new Person("bob", 20, 293749, "somewhere", "janitor", 700f, "merc", "here"),
                new Person("tess", 200, 1237, "somewhere", "janitor", 705670f, "merc", "here"),
                new Person("joke", 19, 91237, "somewhere", "janitor", 70230f, "merc", "here")
            };

            foreach (var item in peoples)
            {
                Console.WriteLine("name: " + item.name);
                Console.WriteLine("age: " + item.age);
                Console.WriteLine("salary: " + item.job.salary);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("add new person.");
            Console.WriteLine("write name.");
            string name = Console.ReadLine().ToString();

            Console.WriteLine("---");
            Console.WriteLine("write age.");
            int age = Convert.ToInt32(Console.ReadLine().ToString().Trim());

            Console.WriteLine("---");
            Console.WriteLine("write person number.");
            int personNr = Convert.ToInt32(Console.ReadLine().ToString().Trim());

            Console.WriteLine("---");
            Console.WriteLine("write adress.");
            string adress = Console.ReadLine().ToString();

            Console.WriteLine("---");
            Console.WriteLine("write job.");
            string job = Console.ReadLine().ToString();

            Console.WriteLine("---");
            Console.WriteLine("write salary.");
            double salary = Convert.ToDouble(Console.ReadLine().Trim());

            Console.WriteLine("---");
            Console.WriteLine("write employer.");
            string employer = Console.ReadLine().ToString();

            Console.WriteLine("---");
            Console.WriteLine("write work adress.");
            string workAdress = Console.ReadLine().ToString();

            peoples.Add(new Person(name, age, personNr, adress, job, salary, employer, workAdress));
        }
    }
}
