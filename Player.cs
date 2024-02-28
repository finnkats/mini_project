public class Player{
    public int MaximumHitPoints;
    public int CurrentHitPoints;
    public Location CurrentLocation;
    public Weapon CurrentWeapon;
    public string? Name;
    public List<HealingItem> HealingItems = new();
    public List<int> DefeatedMonsters = new();
    public int QuestsCompleted = 0;

    public int keys;
    public Player(int HitPoints, string? name){
        MaximumHitPoints = HitPoints;
        CurrentHitPoints = HitPoints;
        Name = name;
        CurrentLocation = World.Locations[0];
        CurrentWeapon = World.Weapons[0];

        for (int i = 0; i < World.RandomGenerator.Next(1, 3); i++){
            HealingItems.Add(World.HealingItems[World.RandomGenerator.Next(1, World.HealingItems.Count) - 1]);
        }
    }

    public bool TryMoveTo(Location? newLocation){
        if (newLocation != null)
        {
            CurrentLocation = newLocation;
            return true;
        }
        return false;
    }

    public void UseInventory(){
        int index = 1;
        Console.WriteLine("Current Items in inventory:");
        foreach (HealingItem item in HealingItems){
            Console.WriteLine($"{index++}: {item.Name}, {item.Description}");
        }
        Console.Write("Enter the number of the item you want to use, anything else to exit.\n>");
        int.TryParse(Console.ReadLine(), out int choice);
        if (choice > 0 && choice <= HealingItems.Count()){
            HealingItem item = HealingItems[--choice];
            CurrentHitPoints += item.HealAmount;
            HealingItems.RemoveAt(choice);
            bool IsAlive = CheckHPStatus();
            Console.WriteLine($"You healed for {item.HealAmount} and your HP is now {CurrentHitPoints}");
            if (!IsAlive){
                Console.WriteLine("You are dead");
            }
        }

    }

    public bool CheckHPStatus(){
        if (CurrentHitPoints <= 0){
            return false;
        }
        if (CurrentHitPoints > MaximumHitPoints){
            CurrentHitPoints = MaximumHitPoints;
        }
        return true;
    }

    public void Death(){
        CurrentLocation = World.Locations[0];
        CurrentHitPoints = MaximumHitPoints;
        Console.WriteLine("You are back home.");
    }
}
