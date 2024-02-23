using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Starting the game...");

        bool gameLoop = true;
        while(gameLoop)
        {
            Console.WriteLine("\nPress \'Q\' when you want to quit");
            Console.WriteLine("\nOr press any other key to start the game");

            if(Console.ReadKey(true).Key == ConsoleKey.Q)
            {
                gameLoop = false;
                Console.WriteLine("Quitting the game...");
            }
            else
            {
                // Explore the word in this code block
                // Console.WriteLine("")
            }
        }
        // For messages or functions after quitting the game
    }
}
