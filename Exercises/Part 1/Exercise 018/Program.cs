﻿using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give the first number!");
      string firstNro = Console.ReadLine();
      Console.WriteLine("Give the second number!");
      string secondNro = Console.ReadLine();
      Console.WriteLine("Give the third number!");
      string thirdNro = Console.ReadLine();
      Console.WriteLine("The sum is " + (Convert.ToInt32(firstNro) + Convert.ToInt32(secondNro) + Convert.ToInt32(thirdNro)));

    }
  }
}
