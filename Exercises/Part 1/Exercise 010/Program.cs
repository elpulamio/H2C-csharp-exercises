using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I will tell a story, but I need some information.");
            Console.WriteLine("Give a name for main character:"); 
            String name = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            String profession = Console.ReadLine();
            Console.WriteLine("Here is the story:\nOnce upon a time there was a " + profession + " called " + name + ".\n" +
                "On their way to work, " + name + " often pondered what being " + profession + " meant to them.\n" +
                "When you work as a " + profession + " you meet interesting people.\n" +
                name + " enjoys their work as " + profession + ", The end.");
            
        }
    }
}
