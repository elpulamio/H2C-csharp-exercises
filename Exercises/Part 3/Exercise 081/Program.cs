using System;
using System.Collections.Generic;

namespace exercise_81
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your method here
      int[] array = {5, 1, 3, 4, 2};
      PrintNeatly(array);
    }

    public static void PrintNeatly(int[] array)
    {
        for (int i = 0; i < array.Length; i++) 
        {
            Console.Write(array[i]);
            if ((i+1) < array.Length)
            {
                Console.Write(", ");
            }
            else
            {
                //To get the console info text (Press any key...) at the end into next line
                Console.WriteLine();    
            }
        }
    }
  }
}

