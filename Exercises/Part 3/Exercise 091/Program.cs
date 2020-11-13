using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
        string name = "";
        int age = 0;
        while (true)
        {
            string person = Console.ReadLine();
            if (person == "")
            {
                break;
            }
            
            string[] info = person.Split(',');
            for (int i = 0; i < info.Length; i++)
            {
                if (name == "" || Convert.ToInt32(info[1]) > age)
                {
                    name = info[0];
                    age = Convert.ToInt32(info[1]);
                }
            }
        }
        Console.WriteLine("Name of the oldest: " + name);
    }
  }
}



