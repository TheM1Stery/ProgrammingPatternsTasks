namespace SingletonTask;
using System.Collections.Generic;

public class Map
{
    private HashSet<Coordinates> _coordinates;
    private readonly RaidBoss _boss;
    
    public Map()
    {
        _boss = RaidBoss.Instance;
        _coordinates = new HashSet<Coordinates>();
    }
}