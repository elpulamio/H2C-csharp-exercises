using System;

namespace exercise_99
{
  class Program
  {
    public static void Main(string[] args)
    {

      DecreasingCounter counter = new DecreasingCounter(5);
      counter.PrintValue();

      counter.Decrement();
      counter.PrintValue();

      counter.Decrement();
      counter.PrintValue();

      counter.Decrement();
      counter.PrintValue();

      counter.Decrement();
      counter.PrintValue();

      counter.Decrement();
      counter.PrintValue();

      counter.Decrement();
      counter.PrintValue();

      DecreasingCounter counter2 = new DecreasingCounter(10);
      counter2.PrintValue();
      counter2.Reset();
      counter2.PrintValue();
    }
  }
}



