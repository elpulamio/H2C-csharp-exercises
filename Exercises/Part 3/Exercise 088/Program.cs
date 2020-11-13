using System;
using System.Collections.Generic;

namespace exercise_88
{
  class Program
  {
    public static void Main(string[] args)
    {
        while (true)
        {
            string sentence = Console.ReadLine();
            if (sentence == "")
            {
                break;
            }
            
            string[] words = sentence.Split(' ');
            Console.WriteLine(words[0]);
        }
    }
  }
}



