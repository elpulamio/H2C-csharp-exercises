using System;

namespace exercise_12
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give a number!");
        string UserInput = Console.ReadLine();
        int number = Convert.ToInt32(UserInput);
        Console.WriteLine("You gave " + number);

    }
  }
}
