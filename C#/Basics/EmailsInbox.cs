using System;

namespace Inbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int emails = 60;

            while (emails > 0)
            {
                emails--;
                Console.WriteLine($"You have {emails} emails left.");
            }

            if (emails == 0)
            {
                Console.WriteLine("NICE! All emails have been officially deleted from your Inbox.");
            }
        }
    }
}