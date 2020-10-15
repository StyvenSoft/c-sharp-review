using System;

namespace GettingInput
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      Console.WriteLine($"You are {input} years old!");
    }
  }
}

// dotnet run

/* Calculates tomorrow's rain likelihood
as a number between 0 and 100 */
