using System;

namespace DictionaryDemo;
/// <summary>
/// User Crud in Dictionary
/// </summary>
public class UserService
{
    private Dictionary<int, string> users = new Dictionary<int, string>();

    public void AddUser(int id, string name)
    {
        if (!users.TryAdd(id, name))
        {
            users[id] = name;
        }
    }
    public string? GetUserName(int id)
    {
        if (users.TryGetValue(id, out string? value))
        {
            return value;
        }
        else
        {
            return null;
        }
    }
    public bool RemoveUser(int id)
    {
        if (users.ContainsKey(id))
        {
            return users.Remove(id);
        }
        else
        {
            return false;
        }
    }
}
