using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("How many days?");
      string uInput = Console.ReadLine();
      int days = Convert.ToInt32(uInput);
      //seconds = days * hours per day * minutes per hour * seconds per minute
      int seconds = days * 24 * 60 * 60;
      Console.WriteLine(days + " days is " + seconds + " seconds.");

    }
  }
}
