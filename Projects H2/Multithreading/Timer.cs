using System;
using System.Threading.Tasks;

namespace Multithreading
{
    public delegate void Input();
    public class Timer
    {
        public static Task Reminder(int seconds, Input input)
        {
            int j = seconds;
            Task task = new Task(() => {;
                for (int i = 0; i < seconds; i++)
                {
                    Console.WriteLine();
                    input(); Console.WriteLine(j);
                    Task.Delay(1000).Wait();
                    j--;
                }
            });
            task.Start();
            return task;
        }

        public static Task Countdown(int seconds)
        {
            int j = seconds;
            Task task = new Task(() => {
                for (int i = 0; i < seconds; i++)
                {
                    Console.WriteLine(j);
                    Task.Delay(1000).Wait();
                    j--;
                }
            });
            task.Start();
            return task;
        }
    }
}
