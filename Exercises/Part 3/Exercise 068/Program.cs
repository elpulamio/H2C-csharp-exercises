using System;
using System.Collections.Generic;

namespace exercise_68
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
      int x = list.Count;
      for (int i = 0; i < x; i++)
      {
        Console.WriteLine(list[i]);      
      }
    }
  }
}
