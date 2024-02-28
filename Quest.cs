using System.Reflection.Metadata;

public class Quest{
    public string Description;
    public int ID;
    public string Name;
    public bool Completed = false;
    public int MonsterRequiredForCompletion = 0;
    public Quest(int id, string name, string description){
        Description = description;
        ID = id;
        Name = name;
    }

    public bool CheckQuest(Player User){
        if (Completed) return false;
        if (User.DefeatedMonsters.Contains(MonsterRequiredForCompletion)){
            Console.WriteLine($"You completed the quest {Name}");
            Completed = true;
            User.QuestsCompleted++;
            if (User.QuestsCompleted == World.QUESTS_AMOUNT_FOR_COMPLETION){
                Console.WriteLine("\n======================================\n" +
                                  "You finished all quests and completed the game!\n" +
                                  "======================================\n");
                return true;
            }
            return false;
        }
        Console.WriteLine($"Quest {Name} available here.\n~{Description}~");
        return false;
    }
}