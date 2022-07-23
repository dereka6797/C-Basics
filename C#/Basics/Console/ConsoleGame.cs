using System;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro Card
            string appName = "Guess the Number";
            string version = "1.0.2";
            string creator = "Derek Booton";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to {0} - Version: {1} - Created By: {2}", appName, version, creator);
            Console.ResetColor();

            //Introduction
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("What's your name?");
            Console.ResetColor();
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Nice to meet you " + name + ". Would you like to play a game? (y,n)");
            Console.ResetColor();
            string reply = Console.ReadLine();
            
            //Case y || n
            Console.ForegroundColor = ConsoleColor.Blue;
            switch(reply)
            {
                case "y":
                    Console.WriteLine("Perfect, let's get started. First begin by guessing a number between 1 & 10.");
                    break;
                case "n":
                    Console.WriteLine("Ahh I see, so you've decided to waste both yours and my time.");
                    break;
            }
            Console.ResetColor();

            //Numbers Guessed
            int correctNumber = 5;
            int guess = 0;

            while (guess != correctNumber)
            {
                string input = Console.ReadLine();
                guess = Int32.Parse(input);
                Console.ForegroundColor = ConsoleColor.Blue;
                switch(guess)
                {
                    case 1:
                    case 10:
                        Console.WriteLine("Remember, I said BETWEEN 1 & 10.");
                        break;
                    case 2:
                    case 3:
                        Console.WriteLine("Wow, I mean your a little cold but getting there.");
                        break;
                    case 4:
                        Console.WriteLine("I don't know how much closer you can get.. oh wait you can but on the opposite spectrum.. if that makes sense.");
                        break;
                    case 5:
                        Console.WriteLine("Holy shite' you did it! Congratulations my friend.");
                        break;
                    case 6:
                    case 7:
                        Console.WriteLine("Not too shabby, falling behind a little but you'll get it.");
                        break;
                    case 8:
                    case 9:
                        Console.WriteLine("Pretty damn freezing over here, may want to turn back");
                        break;
                }
                Console.ResetColor();
            }

            //After guessing right number
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("How many tries did it take you?");
            Console.ResetColor();
            while (guess == correctNumber)
            {
                string tries = Console.ReadLine();
                guess = Int32.Parse(tries);
                Console.ForegroundColor = ConsoleColor.Yellow;
                switch (guess)
                {
                    case 1:
                    case 2:
                        Console.WriteLine("Wow, I'm truly impressed, couldn't had done it better myself.");
                        break;
                    case 3:
                    case 4:
                        Console.WriteLine("Not too many then, very good job!");
                        break;
                    case 5:
                    case 6:
                    case 7:
                        Console.WriteLine("Took quite a few but hey, better than most probably.");
                        break;
                    case 8:
                    case 9:
                        Console.WriteLine("Jeez, you must not like these kinds of games huh?");
                        break;
                    default:
                        Console.WriteLine("If I were you, I'd just stay away from these guessing type games okay?");
                        break;
                }
                Console.ResetColor();
            }
        }
    }
}
