using System;

namespace exercise_20
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give the first number!");
      string firstNro = Console.ReadLine();
      Console.WriteLine("Give the second number!");
      string secondNro = Console.ReadLine();
      Console.WriteLine(Convert.ToInt32(firstNro) + " * " + Convert.ToInt32(secondNro) + " = " + (Convert.ToInt32(firstNro) * Convert.ToInt32(secondNro)));

    }
  }
}
