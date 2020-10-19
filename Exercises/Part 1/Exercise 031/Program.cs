using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      string number = Console.ReadLine();
      int nro = Convert.ToInt32(number);
      int rem = nro % 2;
      if (rem == 0)
      {
        Console.WriteLine("It is even.");      
      }
      else
      {
        Console.WriteLine("It is odd.");
      }

    }
  }
}
