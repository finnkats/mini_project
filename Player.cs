public class Player{
    public int MaximumHitPoints;
    public int CurrentHitPoints;
    public Location CurrentLocation;
    public Weapon? CurrentWeapon = null;
    public string? Name;
    public Player(int HitPoints, string? name){
        MaximumHitPoints = HitPoints;
        CurrentHitPoints = HitPoints;
        Name = name;
        CurrentLocation = World.Locations[0];
    }

    public bool TryMoveTo(Location newLocation){
        if (newLocation != null)
        {
            CurrentLocation = newLocation;
            return true;
        }
        return false;
    }

}
