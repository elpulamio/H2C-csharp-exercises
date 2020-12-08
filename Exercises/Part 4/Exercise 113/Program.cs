using System;
using System.Collections.Generic;

namespace exercise_113
{
  class Program
  {
    public static void Main(string[] args)
    {
        List<Book> list = new List<Book>();

        String title = "";
        int pages = 0;
        int year = 0;

        while (true)
        {
            Console.Write("Name: ");
            title = Console.ReadLine();
            if (title == "")
            {
                break;
            }
            Console.Write("Pages: ");
            pages = Convert.ToInt32(Console.ReadLine());
            Console.Write("Publication year: ");
            year = Convert.ToInt32(Console.ReadLine());
            
            list.Add(new Book(title, pages, year));
        }
        Console.WriteLine();
        Console.Write("What information will be printed?: ");
        String answer = Console.ReadLine();
         
        if (answer == "everything")
        {
            foreach (Book item in list)
            {
                Console.WriteLine(item);
            }
        }   
        else if (answer == "title")
        {
            foreach (Book item in list)
            {
                Console.WriteLine(item.title);
            }
        }
    }
  }
}




