using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      int nro = Convert.ToInt32(Console.ReadLine());
      if (nro < 0)
      {
        nro = nro * (-1);      
      }
      Console.WriteLine(nro);

    }
  }
}
