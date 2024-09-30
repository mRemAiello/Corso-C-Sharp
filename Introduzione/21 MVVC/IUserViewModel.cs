public interface IUserViewModel
{
    public abstract IEnumerable<User> GetUsers();

    //
    public abstract void AddUser(string name, int age);
    public abstract void RemoveUser(string name);
    public abstract void ClearUsers();
}