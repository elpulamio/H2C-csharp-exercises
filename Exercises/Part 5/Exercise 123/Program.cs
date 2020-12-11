using System;

namespace exercise_123
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your code here.
      Counter counter1 = new Counter(0);
      Counter counter2 = new Counter(10);
            
      Console.WriteLine("Counter 1:");
      counter1.Increase();
      counter1.Increase();
      counter1.Decrease();
      counter1.Decrease(-10);
      Console.WriteLine(counter1.value);
      Console.WriteLine();
      Console.WriteLine("Counter 2:");
      counter2.Increase(-10);
      counter2.Increase(5);
      counter2.Decrease(2);
      Console.WriteLine(counter2.value);
      Console.WriteLine();
    }
  }
}
