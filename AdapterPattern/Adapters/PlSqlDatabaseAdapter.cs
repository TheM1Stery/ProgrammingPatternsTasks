using AdapterPattern.Databases;

namespace AdapterPattern.Adapters;

public class PlSqlDatabaseAdapter : IDatabase
{
    private readonly PlSqlDatabase _database;

    public PlSqlDatabaseAdapter(PlSqlDatabase database)
    {
        _database = database;
    }

    public string Name => "PlSqlDatabase";

    public void AddUser(User user)
    {
        _database.PushUser(user);
    }

    public User GetUser(int id)
    {
        return _database.GetUser(id);
    }

    public bool RemoveUser(int id)
    {
        return _database.RemoveUser(id);
    }
}