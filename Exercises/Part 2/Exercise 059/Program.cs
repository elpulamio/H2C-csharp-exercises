using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Greatest(-5, 11, 1);
      Console.WriteLine("Greatest: " + answer);
    }

    public static int Greatest(int number1, int number2, int number3) 
    {
        int ret = 0;
        if (number1 > number2 && number1 > number3)
        {
            ret = number1;
        }
        else if (number2 > number1 && number2 > number3)
        {
            ret = number2;  
        }
        else
        {
            //returns number3 also if all numbers are same
            ret = number3;
        }
        return ret;
    }

  }
}
