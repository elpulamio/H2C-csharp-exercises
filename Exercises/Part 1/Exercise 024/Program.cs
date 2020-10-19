using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Your speed:");
      string number = Console.ReadLine();
      int nro = Convert.ToInt32(number);
      if (nro > 120)
      {
        Console.WriteLine("Speeding!");      
      }
      
    }
  }
}
