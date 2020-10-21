using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Where to?");
      int nro = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where from?");
      int nro2 = Convert.ToInt32(Console.ReadLine());
      while (nro2 <= nro)
      {
        Console.WriteLine(nro2);
        nro2++;
      }
      
    }
  }
}
