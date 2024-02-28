public static class SuperAdventure{

    public static bool Fight(Player player, Monster monster){
        Console.WriteLine($"{player.Name} encounters a {monster.Name} with HP {monster.CurrentHitPoints}.");

        Console.WriteLine($"Options:");
        Console.WriteLine("press 'F' to engage in a fight");
        Console.WriteLine("Press 'R' to Run away");

        string userChoice = Console.ReadLine().ToUpper();
        if (userChoice ==  "F"){
            Console.WriteLine($"{player.Name} decides to engage in a fight!");

            while (player.CurrentHitPoints > 0 && monster.CurrentHitPoints > 0){
                Console.WriteLine($"Options:");
                Console.WriteLine("Press 'A' to Attack");
                Console.WriteLine("Press 'N' to do nothing");
                string actionChoice = Console.ReadLine().ToUpper();

                switch(actionChoice){
                    case "A":
                        Console.WriteLine($"{player.Name} attacks the monster!");
                        monster.CurrentHitPoints -= player.CurrentWeapon.MaximumDamage;
                        Console.WriteLine($"Monster's remaining HP: {monster.CurrentHitPoints}");

                        if (monster.CurrentHitPoints <= 0){
                            Console.WriteLine($"{player.Name} defeats the monster!");
                            return true;
                        }
                        Console.WriteLine($"The monster attacks {player.Name}!");
                        player.CurrentHitPoints -= monster.GenerateRandomDamage();
                        Console.WriteLine($"{player.Name}'s remaining HP: {player.CurrentHitPoints}");

                        if (player.CurrentHitPoints <= 0){
                            Console.WriteLine($"{player.Name} has been defeated by the monster!");
                            return false;
                        }
                        break;

                    case "N":
                        Console.WriteLine($"{player.Name} chooses not to attack.");
                        Console.WriteLine($"The monster attacks {player.Name}!");
                        player.CurrentHitPoints -= monster.GenerateRandomDamage();
                        Console.WriteLine($"{player.Name}'s remaining health: {player.CurrentHitPoints}");

                        if (player.CurrentHitPoints <= 0){
                            Console.WriteLine($"{player.Name} has been defeated by the monster!");
                            return false;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please choose again.");
                        break;
                }
                Console.WriteLine();
            }
    }  else if (userChoice == "R"){
            Console.WriteLine($"{player.Name} decides to run away!");
            return true;
        }
        return true;
    }
}
