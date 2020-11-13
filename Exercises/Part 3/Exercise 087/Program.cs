using System;
using System.Collections.Generic;

namespace exercise_87
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
                if (words[i].Contains("av"))
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }

  }

}

