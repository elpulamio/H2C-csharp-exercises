using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("How many times?");
        int count = Convert.ToInt32(Console.ReadLine());
        PrintPhrase(count);
 
    }

    public static void PrintPhrase(int count) 
    {
        int i = 0;
        while (count > i)
        {
            Console.WriteLine("In a hole in the ground there lived a method");
            i++;
        }
    }
  }
}
