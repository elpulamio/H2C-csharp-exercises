using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      int nro = Convert.ToInt32(Console.ReadLine());
      int nro2 = Convert.ToInt32(Console.ReadLine());
      double result = Math.Sqrt(nro+nro2);
      Console.WriteLine(result);
    
    }
  }
}
