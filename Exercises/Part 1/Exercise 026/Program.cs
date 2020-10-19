using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give your age:");
      string age = Console.ReadLine();
      int ageInt = Convert.ToInt32(age);
      if (ageInt < 1900)
      {
        Console.WriteLine("You're old");      
      }

    }
  }
}
