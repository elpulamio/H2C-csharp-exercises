using System;

namespace exercise_34
{
  class Program
  {
    public static void Main(string[] args)
    {
      string msg = "-";
      while (msg != "no")
      {
        Console.WriteLine("Do you want to continue?");
        msg = Console.ReadLine();
      }

    }
  }
}
