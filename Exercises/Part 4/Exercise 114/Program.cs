using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {
            String line = "";
            int count = 0;

            while (line != "end") 
            {
                line = Console.ReadLine();
                count++;
            }
            Console.WriteLine(count-1);
        }
    }
}
