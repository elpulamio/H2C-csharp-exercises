using System;

namespace exercise_60
{
  class Program
  {
    public static void Main(String[] args)
    {
        PrintStars(5);
        PrintStars(3);
        PrintStars(9);
        Console.WriteLine("");
        PrintSquare(4);
        Console.WriteLine("");
        PrintRectangle(17, 3);
        Console.WriteLine("");
        PrintTriangle(4);

    }

    public static void PrintStars(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine("");
    }

    public static void PrintSquare(int size)
    {
        for (int x = 0; x < size; x++)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }

    public static void PrintRectangle(int width, int height)
    {
        for (int i = 0; i < height; i++)
        {
            PrintStars(width);
        }
    }

    public static void PrintTriangle(int size)
    {
        for (int i = 1; i <= size; i++)
        {
            PrintStars(i);
        }
    }
  }
}
