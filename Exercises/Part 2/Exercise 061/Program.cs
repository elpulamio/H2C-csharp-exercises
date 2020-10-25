using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
        PrintRightTriangle(4);
        Console.WriteLine("");
        ChristmasTree(20);
    }

    public static void PrintStars(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Console.Write("*");
        }
    }

    public static void PrintSpaces(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Console.Write(" ");
        }
    }

    public static void PrintRightTriangle(int size)
    {
        int e = size;
        int x = 1;
        for (int i = 0; i < size; i++)
        {
            e = e - 1;
            PrintSpaces(e);
            PrintStars(x);
            Console.WriteLine("");
            x++;
        }
    }

    public static void ChristmasTree(int height)
    {
        int width = -1;
        int count = 0;
        while (count < height)
        {
            width = width + 2;
            count++;
        }

        int midpoint = width / 2;
        int midpointStart = midpoint - 1;
        int x = 1;
        for (int i = 0; i < height; i++)
        {
            PrintSpaces(midpoint);
            PrintStars(x);
            PrintSpaces(midpoint);
            x = x + 2;
            midpoint = midpoint - 1;
            Console.WriteLine("");
        }
        PrintSpaces(midpointStart);
        PrintStars(3);
        PrintSpaces(midpointStart);
        Console.WriteLine("");
        PrintSpaces(midpointStart);
        PrintStars(3);
        PrintSpaces(midpointStart);
        Console.WriteLine("");
    }
  }
}
