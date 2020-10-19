using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give the first number!");
      string firstNro = Console.ReadLine();
      Console.WriteLine("Give the second number!");
      string secondNro = Console.ReadLine();
      int Nro1 = Convert.ToInt32(firstNro);
      int Nro2 = Convert.ToInt32(secondNro);
      int sum = Nro1 + Nro2;
      double average = sum / 2.0;
      Console.WriteLine("The average is " + average);
    }
  }
}
