using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give numbers:");
      int nro = 0;
      int sum = 0;
      int count = 0;
      int even = 0;
      int odd = 0;
      int calc = 0;
      
      while (nro != -1)
      {
        nro = Convert.ToInt32(Console.ReadLine());
        calc = nro % 2;
        if (nro != -1)
        {
            sum = sum + nro;
            count++;
            if (calc == 0)
            {
                even++;        
            }
            else
            {
                odd++;       
            }
        }
      }
      
      Console.WriteLine("Thx! Bye!");
      Console.WriteLine("Sum: " + sum);
      Console.WriteLine("Numbers: " + count);
      Console.WriteLine("Average: " + (double)sum / count);
      Console.WriteLine("Even: " + even);
      Console.WriteLine("Odd: " + odd);
    }
  }
}
