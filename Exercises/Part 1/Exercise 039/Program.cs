using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      int nro = 1;
      string msg = "-";
      while (nro != 0)
      {
                Console.WriteLine("Give a number:");
                msg = Console.ReadLine();
                nro = Convert.ToInt32(msg);
                if (nro != 0)
                {
                    sum = sum + nro;
                }
      }
      Console.WriteLine("Total sum of numbers: " + sum);
    }
  }
}
