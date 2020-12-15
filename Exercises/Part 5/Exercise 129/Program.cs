using System;

namespace exercise_129
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Try your code here, if you want
      Song jackSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
      Song anotherSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
      Song otherSong = new Song("The Other Song", "Other Artist", 196);

      if (jackSparrow.Equals(anotherSparrow))
      {
        Console.WriteLine("Songs are equal.");
      }

      if (jackSparrow.Equals(otherSong))
      {
        Console.WriteLine("Songs are equal.");
      } 
      else 
      {
        Console.WriteLine("Not same.");      
      }
    }
  }
}
