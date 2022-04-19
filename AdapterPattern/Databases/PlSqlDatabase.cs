namespace AdapterPattern.Databases;

public class PlSqlDatabase
{
    private List<User> _users = new();
    
    public void PushUser(User user)
    {
        _users.Add(user);
    }

    public User GetUser(int id)
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