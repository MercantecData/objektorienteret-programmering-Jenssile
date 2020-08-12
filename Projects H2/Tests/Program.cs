using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class Program : Timer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have 10 seconds to guess a number between 1 and 10");
            Console.WriteLine("press enter to begin.");
            Console.ReadLine();

            int j = 3;
            var countdown = Countdown(j);
            Task.WaitAll(countdown);

            j = 10;
            Reminder(j, () => Console.Write("seconds left: "));
            Console.ReadLine();
        }
    }
}
