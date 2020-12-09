using System;
using System.IO;

namespace exercise_116
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Read the file data.txt and print the text from it as it is
      // You can use either File.ReadAllText or File.ReadAllLines
   
      string data = File.ReadAllText(@"C:\Users\Admin\source\repos\elpulamio\H2C-csharp-exercises\Exercises\Part 4\Exercise 116\data.txt");
      Console.WriteLine(data);

    }
  }
}
