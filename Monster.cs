public class Monster{
    public int CurrentHitPoints;
    public int ID;
    public int MaximumDamage;
    public int MaximumHitPoints;
    public string Name;

    public Monster(int id, string name, int maxDamage, int currHP, int maxHP){
        ID = id;
        Name = name;
        MaximumDamage = maxDamage;
        CurrentHitPoints = currHP;
        MaximumHitPoints = maxHP;
    }
}