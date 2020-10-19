using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("How old are you?");
      string age = Console.ReadLine();
      int ageInt = Convert.ToInt32(age);
      if (ageInt >= 18)
      {
        Console.WriteLine("You're an adult!");      
      }
      else
      {
        Console.WriteLine("You're under age!");      
      }

    }
  }
}
