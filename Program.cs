using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Starting the game...");
        Console.Write("Enter character name:\n>");
        // Sets User hitpoints to 100 and their name
        Player User = new(100, Console.ReadLine());
        bool gameLoop = true;
        while(gameLoop)
        {
            Console.WriteLine("Press 'M' to open Map and look at the possible locations");
            Console.Write("Press \'Q\' when you want to Quit\n>");

            string? Input = Console.ReadLine().ToUpper();
            switch (Input){
                case "M":
                Console.WriteLine(User.CurrentLocation.Compass()); break;
                case "Q":
                gameLoop = false; break;
            }
            
        }
        // For messages or functions after quitting the game
        Console.WriteLine("Quitting the game...");
    }
}
