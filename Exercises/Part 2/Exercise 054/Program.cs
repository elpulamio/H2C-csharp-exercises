using System;
using System.Security.Cryptography.X509Certificates;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
      DivisibleByThreeInRange(-9,17);

    }

    public static void DivisibleByThreeInRange(int beginning, int end)
    {
        int b = beginning;
        int e = end;
        while (b <= e)
        {
            if (b % 3 == 0)
            {
                Console.WriteLine(b);    
            }
            b++;
        }
    }

  }
}
