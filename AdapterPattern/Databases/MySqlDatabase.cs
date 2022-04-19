namespace AdapterPattern.Databases;

public class MySqlDatabase
{
    private List<User> _users = new();
    
    public void InsertUser(User user)
    {
        _users.Add(user);
    }

    public User GetUserById(int id)
    {
        return _users[id];
    }

    public bool RemoveUser(int id)
    {
        try
        {
            _users.RemoveAt(id);
            return true;
        }
        catch (ArgumentOutOfRangeException)
        {
            return false;
        }
    }
}