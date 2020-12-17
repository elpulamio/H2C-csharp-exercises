using System;

namespace exercise_135
{
    public class UserInterface
    {
        private JokeManager jokeList;

        public UserInterface(JokeManager jokeList)
        {
            this.jokeList = jokeList;
        }

        public void Start()
        {
            Console.WriteLine("What a joke!");

            while (true)
            {
                Console.WriteLine("Commands:");
                Console.WriteLine(" 1 - add a joke");
                Console.WriteLine(" 2 - draw a joke");
                Console.WriteLine(" 3 - list jokes");
                Console.WriteLine(" X - stop");

                string command = Console.ReadLine();

                if (command == "X")
                {
                    break;
                }

                if (command == "1")
                {
                    Console.WriteLine("Write the joke to be added:");
                    string joke = Console.ReadLine();
                    jokeList.AddJoke(joke);
                }

                else if (command == "2")
                {
                    Console.WriteLine("Drawing a joke.");
                    Console.WriteLine(jokeList.DrawJoke());
                }

                else if (command == "3")
                {
                    Console.WriteLine("Printing the jokes.");
                    jokeList.PrintJokes();
                }
            }
        }
    }
}