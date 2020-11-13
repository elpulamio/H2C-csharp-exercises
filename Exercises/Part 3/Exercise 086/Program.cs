using System;
using System.Collections.Generic;

namespace exercise_86
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
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
  }
}

