using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {
      int nro = Convert.ToInt32(Console.ReadLine());
      int nro2 = Convert.ToInt32(Console.ReadLine());
      if (nro > nro2)
      {
        Console.WriteLine(nro + " is greater than " + nro2 + ".");
      }
      else if (nro < nro2)
      {
        Console.WriteLine(nro + " is less than " + nro2 + ".");
      }
      else
      {
        Console.WriteLine(nro + " is equal to " + nro2 + ".");
      }
    }
  }
}
