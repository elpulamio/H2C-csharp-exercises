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
   
      //Must add ../../ before file name, because otherwise default path goes two folder too deep
      string data = File.ReadAllText("../../data.txt");
      Console.WriteLine(data);

    }
  }
}
