using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number!");
      string UserInput = Console.ReadLine();
      double number = Convert.ToDouble(UserInput);
      Console.WriteLine("You gave " + number);

    }
  }
}
