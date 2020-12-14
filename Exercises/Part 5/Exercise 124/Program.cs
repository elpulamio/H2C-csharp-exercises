using System;

namespace exercise_124
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Implement your program here!
      Counter counter = new Counter(0);
      counter = null;
      counter.value = 1;
      Console.WriteLine(counter);
    }
  }
}
