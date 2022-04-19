
namespace AdapterPattern.Databases;

public class MsSqlDatabase
{
    private List<User> _users = new();
    
    public void InsertUser(User user)
    {
        _users.Add(user);
    }

    public User FetchUser(int id)
    {
        return _users[id];
    }

    public bool DeleteUser(int id)
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