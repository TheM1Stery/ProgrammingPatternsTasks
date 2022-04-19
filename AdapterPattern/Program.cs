using AdapterPattern;
using AdapterPattern.Adapters;
using AdapterPattern.Databases;

var client = new Client();

client.AddDatabase(new MsSqlDatabaseAdapter(new MsSqlDatabase()));

var database = client.GetSpecifiedDatabase("MsSqlDatabase");

database.AddUser(new User("TheMystery", "Password", DateTime.Now));

var user = database.GetUser(0);
Console.WriteLine(user.Login);