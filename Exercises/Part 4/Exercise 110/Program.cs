using System;
using System.Collections.Generic;

namespace exercise_110
{
  class Program
  {
    public static void Main(string[] args)
    {
        List<Item> items = new List<Item>();
        String name = "";

        while (true)
        {
            Console.Write("Enter a name, empty will stop: ");
            name = Console.ReadLine();
            if (name == "")
            {
                break;
            }
            items.Add(new Item(name));
        }

        foreach (Item item in items)
        {
            Console.WriteLine(item);
        }
    }
  }
}




