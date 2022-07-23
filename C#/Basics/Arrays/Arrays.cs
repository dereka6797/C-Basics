using System;

namespace SandboxProject
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] age;
      int[] birthYears;

      string [] family = {
        "Derek",
        "Alex", 
        "Bentley",
        "Liam",
        "Oliver"
      };

      foreach (string name in family)
      {
        CallFamily(name);
      };

      age = new int[] {
        25, 
        28, 
        6, 
        2,
        7
      };

      int familyLength = family.Length;
      Console.WriteLine($"There are {familyLength} members of our family!");

      Console.WriteLine($"Bentley is {age[2]} years old!");

      int onList = Array.IndexOf(family, "Liam");
      Console.WriteLine($"Liam is listed {onList + 1}th in this array."); //Be nice to find a way to print 4 instead of zero-index.


      Array.Sort(family);
      Console.WriteLine(family[0]);

      string greeting = "Hello";
      Console.WriteLine($"{greeting} my friend!");

      birthYears = new int[] { 1997, 1995, 2015, 2016, 2020 };
      Console.WriteLine($"My birthyear is {birthYears[0]}.");

      Array.Sort(birthYears);
      Console.WriteLine($"If were putting them in order the first birthyear is {birthYears[0]}, that would be {family[0]}'s birthyear.");

      static void CallFamily(string name)
      {
        Console.WriteLine($"- {name}");
      }

    }
  }
}
