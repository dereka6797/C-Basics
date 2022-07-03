using System;

namespace Name
{
    class assignOp
    {
        static void Main(string[] args) {
            int x = 32;
            x += 2;
            x -= 5;
            x /= 10;
            x *= 4;
            x %= 8;

            Console.WriteLine(x);
        }
    }
}