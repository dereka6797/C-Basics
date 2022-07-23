using System;

namespace Paramters
{
    class Program
    {
        static void Func(int x)
        {
            Console.WriteLine(x*2);
        }
        static void Main(string[] args)
        {
            Func(5);
            Func(14);
            Func(100);
        }
    }
}