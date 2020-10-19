using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give a string:");
      string message = Console.ReadLine();
      Console.WriteLine("Give an integer:");
      string numberStr = Console.ReadLine();
      Console.WriteLine("Give a double:");
      string dNumberStr = Console.ReadLine();
      Console.WriteLine("Give a boolean:");
      string boolStr = Console.ReadLine();
      
      Console.WriteLine("Your string: " + message);
      Console.WriteLine("Your integer: " + Convert.ToInt32(numberStr));
      Console.WriteLine("Your double: " + Convert.ToDouble(dNumberStr));
      Console.WriteLine("Your boolean: " + Convert.ToBoolean(boolStr));

    }
  }
}
