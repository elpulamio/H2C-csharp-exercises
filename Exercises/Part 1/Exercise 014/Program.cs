using System;

namespace exercise_14
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give me the truth!");
      string UserInput = Console.ReadLine();
      bool truth = Convert.ToBoolean(UserInput);
      Console.WriteLine(truth);
      
    }
  }
}
