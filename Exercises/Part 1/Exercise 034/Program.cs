using System;

namespace exercise_34
{
  class Program
  {
    public static void Main(string[] args)
    {
      string msg = "-";
      while (true)
      {
        Console.WriteLine("Do you want to continue?");
        msg = Console.ReadLine();
        if (msg == "no")
        {
            break;
        }
      }

    }
  }
}
