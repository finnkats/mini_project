public class Location
{
    public int ID;
    public string Name;
    public string Description;
    public Location? LocationToNorth = null;
    public Location? LocationToEast = null;
    public Location? LocationToSouth = null;
    public Location? LocationToWest = null;
    public Quest? QuestAvailableHere = null;
    public Monster? MonsterLivingHere = null;
    public Location(int id, string name, string description, Quest? QuestHere, Monster? MonsterHere)
    {
        ID = id;
        Name = name;
        Description = description;
        QuestAvailableHere = QuestHere;
        MonsterLivingHere = MonsterHere;
    }

    public string Compass()
    {
        //Settings > Debug > Console: Collapse Identical Lines
        string s = "From here you can go:\n";
        if (LocationToNorth != null)
        {
            s += "    N\n    |\n";
        }
        if (LocationToWest != null)
        {
            s += "W---|";
        }
        else
        {
            s += "    |";
        }
        if (LocationToEast != null)
        {
            s += "---E";
        }
        s += "\n";
        if (LocationToSouth != null)
        {
            s += "    |\n    S\n";
        }
        return s;
    }

    public Location? GetLocationAt(string location)
    {
        if (location == "N") return LocationToNorth;
        if (location == "E") return LocationToEast;
        if (location == "S") return LocationToSouth;
        if (location == "W") return LocationToWest;
        return null;
    }
}