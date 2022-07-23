using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 32;
            int value2 = 60;

            if(value1 > value2)
            {
                Print($"{value1} is larger than {value2}");
            } else if(value2 > value1)
            {
                Print($"{value2} is larger than {value1}");
            } else
            {
                Print("None of these values are larger than each other.");
            }
        }
    }
}