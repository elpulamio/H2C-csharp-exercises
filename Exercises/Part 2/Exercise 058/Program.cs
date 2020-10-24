using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
    }

    public static int Smallest(int number1, int number2)
    {
        int ret = 0;
        if (number1 < number2)
        {
            return number1;    
        }
        else if (number2 < number1)
        {
            ret = number2;    
        }
        //returns zero if numbers are same
        return ret;
    }
    
  }
}
