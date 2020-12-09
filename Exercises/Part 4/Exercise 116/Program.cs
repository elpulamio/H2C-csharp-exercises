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
      
      //Could not get loaded the data.txt -file in project folder
      //I tried to manipulate .csproj -file and many many other tricks,
      //but nothing worked. Always get the path not found -error.
      //So, I just use local file here:
      string data = File.ReadAllText("c:/C#exercises/data.txt");
      Console.WriteLine(data);

    }
  }
}
