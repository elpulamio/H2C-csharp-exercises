using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      string nro = Console.ReadLine();
      int nroInt = Convert.ToInt32(nro);
      if (nroInt > 0)
      {
        Console.WriteLine("It is positive.");      
      }
      else
      {
        Console.WriteLine("It is not positive.");      
      }

    }
  }
}
