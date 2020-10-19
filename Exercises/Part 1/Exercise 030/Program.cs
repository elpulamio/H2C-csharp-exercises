using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give your percent [0 - 100]:");
      string percent = Console.ReadLine();
      int pInt = Convert.ToInt32(percent);
      
      if (pInt < 0)
      {
        Console.WriteLine("Impossible");
      }
      else if (pInt > -1 && pInt < 50)
      {
        Console.WriteLine("Fail");
      }
      else if (pInt > 49 && pInt < 60)
      {
        Console.WriteLine("1");
      }
      else if (pInt > 59 && pInt < 70)
      {
        Console.WriteLine("2");
      }
      else if (pInt > 69 && pInt < 80)
      {
        Console.WriteLine("3");
      }
      else if (pInt > 79 && pInt < 90)
      {
        Console.WriteLine("4");
      }
      else if (pInt > 89 && pInt < 101)
      {
        Console.WriteLine("5");
      }
      else
      {
        Console.WriteLine("Outstanding!");      
      }
    }
  }
}
