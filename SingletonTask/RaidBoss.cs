namespace SingletonTask;


public record Coordinates
{
    public int X { get; set; }
    public int Y { get; set; }
}

public record RaidBoss
{
    private static RaidBoss? s_instance;

    public static RaidBoss Instance => s_instance ??= new RaidBoss()
    {
        Name = "SuperRaidBoss",
        Health = 100,
        Level = 1337
    };


    private RaidBoss() { }
    
    
    public string? Name { get; init; }
    public int Level { get; init; }
    public bool IsAlive => Health >= 0;
    public int Health { get; set; }
    
    public Coordinates? Coordinates { get; set; }
    
    public void Kill()
    {
        Health = 0;
    }

    public void Revive()
    {
        Health = 100;
    }
}