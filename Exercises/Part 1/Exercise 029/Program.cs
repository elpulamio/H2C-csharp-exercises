using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");
      string nro = Console.ReadLine();
      int nroInt = Convert.ToInt32(nro);
      Console.WriteLine("Give the second number!");
      string nro2 = Console.ReadLine();
      int nro2Int = Convert.ToInt32(nro2);
      if (nroInt > nro2Int)
      {
        Console.WriteLine("The larger number is " + nroInt + "!");      
      }
      else if (nroInt < nro2Int)
      {
        Console.WriteLine("The larger number is " + nro2Int + "!");      
      }
      else
      {
        Console.WriteLine("They are equal!");      
      }

    }
  }
}
