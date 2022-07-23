using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = new string[5];

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What's your name?");
            Console.ResetColor();
            string userName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Nice to meet you {userName}, may I ask how old you are?");
            Console.ResetColor();
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Awesome! Just remember, your age reflects how long you've been alive, it doesn't define who you are.\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("So, why don't you list off your top 5 favorite movies for me and I'll repeat them back?\n");
            Console.ResetColor();
            for (int i = 0; i < 5; i++)
            {
                values[i] = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Really? Your top 5 movies are: \n");
            Console.ResetColor();
            for (int i = 0; i < 5; ++i)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"[{i + 1}] {values[i]}");
                Console.ResetColor();
            }
            string userResponse = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sounds nice, I don't have any favorite movies. What's your favorite color?");
            Console.ResetColor();
            string userColor = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            switch (userColor)
            {
                case "blue":
                    Console.WriteLine("Dude, blue is my son's favorite color. Very cool.");
                    break;
                case "red":
                    Console.WriteLine("There are lot's of reds out there, my favorite is Crimson Red...");
                    break;
                case "yellow":
                    Console.WriteLine("Eh, yellow is okay but definitely not my favorite. The only yellow I like is in the sun.");
                    break;
                case "purple":
                    Console.WriteLine("Now purple is practicaly royalty, also my wife's favorite color so very awesome.");
                    break;
                case "black":
                    Console.WriteLine("Now that is a color I can get with, though I am not fond of the darkness there is something about it that just draws you near.");
                    break;
                case "green":
                    Console.WriteLine("Green isn't bad, it's used in a lot of ways and especially here ;)");
                    break;
                case "orange":
                    Console.WriteLine("I see orange alot when I'm typing this so it's not my favorite, kind of reminds of something dirty...well so does yellow.");
                    break;
                case "pink":
                    Console.WriteLine("Now that's a color I can get behind, simply because of how well it compliments other colors, like green.");
                    break;
                case "white":
                    Console.WriteLine("...........");
                    break;
                case "brown":
                    Console.WriteLine("Wow... you must not have any taste in anything that's ever existed.. no taste worth considering..");
                    break;
                case "grey":
                    Console.WriteLine("Now, do you spell it grey or gray?");
                    break;
                default:
                    Console.WriteLine("You must be using color names I don't have on here... please just use the generic names or gtfo.");
                    break;
            }
            Console.ResetColor();
        }
    }
}