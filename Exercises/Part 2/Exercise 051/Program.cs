using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
        PrintUntilNumber(7);  
    }

    public static void PrintUntilNumber(int number)
    {
        for (int i = 1; i <= number; i++)
        {
                Console.WriteLine(i);
        }
    }

  }
}
