using System;

namespace Delegates
{
    public delegate int MyDelegate(int x, int y);
    class Program
    {
        static int Sum(int x, int y) { return x + y; }

        static void Main()
        {
            var d = new MyDelegate(Sum);

            int result = d.Invoke(12, 15);

            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}