using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first string:");
      string message = Console.ReadLine();
      Console.WriteLine("Give the second string:");
      string message2 = Console.ReadLine();
      if (message == message2)
      {
        Console.WriteLine("Echo!");
      }
      else
      {
        Console.WriteLine("Nope!");
      }

    }
  }
}
