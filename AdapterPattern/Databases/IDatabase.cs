namespace AdapterPattern.Databases;

public interface IDatabase
{
    public string Name { get; }
    public void AddUser(User user);
    public User GetUser(int id);
    public bool RemoveUser(int id);
}