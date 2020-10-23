using System;

namespace exercise_52
{
    class Program
    {
        public static void Main(String[] args)
        {
            PrintFromNumberToOne(7);  
        }

        public static void PrintFromNumberToOne(int number)
        {
            int x = number;
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(x);
                x--;
            }
        }
    }
}
