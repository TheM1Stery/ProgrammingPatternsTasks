using System.Collections.Generic;
using AdapterPattern.Databases;

namespace AdapterPattern;

public class Client
{
    public List<IDatabase> Databases { get; } = new();

    public void AddDatabase(IDatabase database)
    {
        Databases.Add(database);
    }
    
    
    public IDatabase GetSpecifiedDatabase(string name)
    {
        return Databases.First(x => x.Name == name);
    }
}