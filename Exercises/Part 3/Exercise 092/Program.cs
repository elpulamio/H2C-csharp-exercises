using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
        string name = "";
        int age = -1;
        int height = 0;
        while (true)
        {
            string person = Console.ReadLine();
            if (person == "")
            {
                break;
            }
            
            string[] info = person.Split(',');
            
            if (info[0].Length > height)
            {
                height = info[0].Length;
                name = info[0];
            }
            
            if ((2020 - Convert.ToInt32(info[1])) > age)
            {
                age  = 2020 - Convert.ToInt32(info[1]);
            }
        }
        Console.WriteLine("Longest name: " + name);
        Console.WriteLine("Highest age: " + age);
    }
  }
}



