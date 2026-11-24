namespace TeamBytes;

public class Admin:User
{
    private Library library;
    public Admin(string name, int age, string ssn, Library library) : base(name, age, ssn, UserRole.Admin)
    {
        this.library = library;
    }

    public List<User> ListUsers()
    {
        return library.ListUsers();
    }
    public void CreateUser(User user)
    {
        library.AddUser(user);
    }
    public void DeleteUser(string ssn)
    {
        library.RemoveUser(ssn);
    }
    public void UpdateUser(string ssn, string name, int age)
    {
        User? user = library.FindUser(ssn);
        if (user != null)
        {
            user.UpdateInfo(name, age);
        }
    }
}