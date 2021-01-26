using System;

namespace Delegates
{
    public delegate int MyDelegate(int x, int y);
    public delegate float MyDelegateF();
    public delegate void MyNothing(int x, int y, int z);
    class Program
    {
        static int Sum(int x, int y) { return x + y; }
        static float Float() { return 2.5f; }
        static void Not(int x, int y, int z) { Console.WriteLine(x+y+z); }

        static void Main()
        {
            var d = new MyDelegate(Sum);
            var i = new MyDelegateF(Float);
            var l = new MyNothing(Not);

            int result = d.Invoke(12, 15);
            var f = i.Invoke();
            l.Invoke(1, 2, 3);

            Console.WriteLine(result);
            Console.WriteLine(f);

            Console.ReadLine();

        }
    }
}