using System.Collections.Generic;

public class UserViewModel : IUserViewModel
{
    private List<User> _users;

    public UserViewModel()
    {
        _users = new List<User>();
    }

    public IEnumerable<User> GetUsers()
    {
        return _users;
    }

    public void AddUser(string name, int age)
    {
        User newUser = new User(name, age);
        _users.Add(newUser);
    }

    public void ClearUsers()
    {
        _users.Clear();
    }

    public void RemoveUser(string name)
    {
        throw new NotImplementedException();
    }
}
