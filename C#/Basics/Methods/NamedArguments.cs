using System;

namespace NamedArguments
{
    class Program
    {
        static int Calc(int from, into to, int step = 2)
        {
            int res = 0;
            for(int i = from; i < to; i += step)
            {
                res += 1;
            }
            return res;
        }
        static void Main(string[] args)
        {
            int res = calc(step:2, to: 84, from: 31);
            Console.WriteLine(res);
        }
    }
}