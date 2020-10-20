using System;
using System.Net.Configuration;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
      string msg = "-";
      int nro = 0;
      while (nro != 42)
      {
        Console.WriteLine("Give a number:");
        msg = Console.ReadLine();
        nro = Convert.ToInt32(msg);
      }

    }
  }
}
