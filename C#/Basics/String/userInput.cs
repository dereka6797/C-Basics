using System;

namespace MyApp {
    class program {
        static void Main(string[] args) {
            string yourName;
            Console.WriteLine("What is your name?");

            yourName = Console.ReadLine();

            Console.WriteLine("Hello {0}", yourName);
        }
    }
}