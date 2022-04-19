using System.Collections.Generic;
using AdapterPattern.Databases;

namespace AdapterPattern;

public class Client
{
    private readonly List<IDatabase> _databases = new();

    public void AddDatabase(IDatabase database)
    {
        _databases.Add(database);
    }
    
    public IDatabase GetSpecifiedDatabase(string name)
    {
        return _databases.First(x => x.Name == name);
    }
}