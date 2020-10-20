using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      int nro = 1;
      string msg = "-";
      while (nro != 0)
      {
                Console.WriteLine("Give a number:");
                msg = Console.ReadLine();
                nro = Convert.ToInt32(msg);
                if (nro > 0)
                {
                    nro = nro * nro;
                    Console.WriteLine(nro);
                }
                else if (nro < 0)
                {
                    Console.WriteLine("That is negative");
                }
      }
    }
  }
}
