using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      string number = Console.ReadLine();
      int nro = Convert.ToInt32(number);
      if (nro == 1984)
      {
        Console.WriteLine("Orwell");      
      }

    }
  }
}
