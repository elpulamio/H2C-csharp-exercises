using System;

namespace exercise_115
{
  class Program
  {
    public static void Main(string[] args)
    {
        String input = "";
        int number = 0;
        
        while (true)
        {
            input = Console.ReadLine();
            if (input == "end")
            {
                break;   
            }
            number = Convert.ToInt32(input);
            Console.WriteLine(number * number * number);   
        }
    }
  }
}
