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
            Console.WriteLine();
            Console.WriteLine("N, E, S, W to move in that direction (if possible)");
            Console.WriteLine("Press 'M' to open Map and look at the possible locations");
            Console.WriteLine("Press 'I' to use Inventory");
            Console.Write("Press 'Q' when you want to Quit\n>");

            string? Input = Console.ReadLine().ToUpper();
            switch (Input){
                case "N": case "E": case "S": case "W":
                if (!User.TryMoveTo(User.CurrentLocation.GetLocationAt(Input))){
                    Console.WriteLine("You can't go that way.");
                }; break;
                case "M":
                Console.WriteLine(User.CurrentLocation.Compass()); break;
                case "I":
                User.UseInventory(); break;
                case "Q":
                gameLoop = false; break;
            }
            
        }
        // For messages or functions after quitting the game
        Console.WriteLine("Quitting the game...");
    }
}
