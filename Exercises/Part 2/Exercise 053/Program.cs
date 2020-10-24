using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
      Division(9,7);
    }

    public static void Division(int numerator, int denominator)
    {
        double result = (double)numerator / (double)denominator;
        Console.WriteLine(result);
    }

  }
}
