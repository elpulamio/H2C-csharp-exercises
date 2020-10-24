using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(1, 9);
      Console.WriteLine("Smallest: " + answer);
    }

    public static int Smallest(int number1, int number2)
    {
        int ret = 0;
        if (number1 < number2)
        {
            return number1;    
        }
        else
        {
            ret = number2;    
        }
        //returns number2 also if numbers are same
        return ret;
    }
    
  }
}
