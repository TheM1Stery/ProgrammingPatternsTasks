using AdapterPattern.Databases;

namespace AdapterPattern.Adapters;

public class MySqlDatabaseAdapter : IDatabase
{
    private readonly MySqlDatabase _database;

    public MySqlDatabaseAdapter(MySqlDatabase database)
    {
        _database = database;
    }


    public string Name => "MySqlDatabase";

    public void AddUser(User user)
    {
        _database.InsertUser(user);
    }

    public User GetUser(int id)
    {
        return _database.GetUserById(id);
    }

    public bool RemoveUser(int id)
    {
        return _database.RemoveUser(id);
    }
}