using System;

namespace exercise_23
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
      int sub = Nro1 - Nro2;
      int multi = Nro1 * Nro2;
      double divide = Convert.ToDouble(Nro1) / Convert.ToDouble(Nro2);
      Console.WriteLine(Nro1 + " + " + Nro2 + " = " + sum);
      Console.WriteLine(Nro1 + " - " + Nro2 + " = " + sub);
      Console.WriteLine(Nro1 + " * " + Nro2 + " = " + multi);
      Console.WriteLine(Nro1 + " / " + Nro2 + " = " + divide);
    }
  }
}
