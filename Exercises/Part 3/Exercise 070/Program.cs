using System;
using System.Collections.Generic;

namespace exercise_70
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }
      int greatest = list[0];
      for (int i = 1; i < list.Count; i++)
      {
        if (list[i] > greatest)
        {
            greatest = list[i];
        }
      }
      Console.WriteLine("The greatest number: " + greatest);
    }
  }
}
