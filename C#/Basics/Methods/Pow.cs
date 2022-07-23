using System;

namespace Pow
{
    class Program
    {
        static int Pow(int x, int y = 2)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }
    }
}