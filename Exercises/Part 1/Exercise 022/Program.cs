using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give the first number!");
      string firstNro = Console.ReadLine();
      Console.WriteLine("Give the second number!");
      string secondNro = Console.ReadLine();
      Console.WriteLine("Give the third number!");
      string thirdNro = Console.ReadLine();
      int Nro1 = Convert.ToInt32(firstNro);
      int Nro2 = Convert.ToInt32(secondNro);
      int Nro3 = Convert.ToInt32(thirdNro);
      int sum = Nro1 + Nro2 + Nro3;
      double average = sum / 3.0;
      Console.WriteLine("The average is " + average);

    }
  }
}
