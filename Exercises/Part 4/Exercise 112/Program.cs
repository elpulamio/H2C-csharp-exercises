using System;
using System.Collections.Generic;

namespace exercise_112
{
  class Program
  {
    public static void Main(string[] args)
    {
        List<TelevisionProgram> list = new List<TelevisionProgram>();

        String name = "";
        int duration = 0;

        while (true)
        {
            Console.WriteLine("Name (empty stops the app: ");
            name = Console.ReadLine();
            if (name == "")
            {
                break;
            }
            Console.WriteLine("Duration: ");
            duration = Convert.ToInt32(Console.ReadLine());
            
            list.Add(new TelevisionProgram(name, duration));
        }
        Console.WriteLine();
        Console.WriteLine("Program's maximum duration?");
        int max = Convert.ToInt32(Console.ReadLine());
            
        foreach (TelevisionProgram item in list)
        {
            if (item.duration <= max){ 
                Console.WriteLine(item);
            }
        }
    }
  }
}




