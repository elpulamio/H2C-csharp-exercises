using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      int nro = 1;
      string msg = "-";
      while (true)
      {
                Console.WriteLine("Give a number:");
                msg = Console.ReadLine();
                nro = Convert.ToInt32(msg);
                sum = sum + 1;
                if (nro == 0)
                {
                    break;
                }
      }
      Console.WriteLine("Total amount of numbers: " + (sum-1));
    }
  }
}
