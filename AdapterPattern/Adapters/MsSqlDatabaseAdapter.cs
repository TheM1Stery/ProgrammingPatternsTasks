using AdapterPattern.Databases;

namespace AdapterPattern.Adapters;

public class MsSqlDatabaseAdapter : IDatabase
{
    private readonly MsSqlDatabase _database;

    public MsSqlDatabaseAdapter(MsSqlDatabase database)
    {
        _database = database;
    }

    public string Name => "MsSqlDatabase";

    public void AddUser(User user)
    {
        _database.InsertUser(user);
    }

    public User GetUser(int id)
    {
        return _database.FetchUser(id);
    }

    public bool RemoveUser(int id)
    {
        return _database.DeleteUser(id);
    }
}