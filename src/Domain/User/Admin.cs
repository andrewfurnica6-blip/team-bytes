namespace TeamBytes;

public class Admin:User
{
    public Admin(string name, int age, string ssn) : base(name, age, ssn, UserRole.Admin)
    {
    }

    public List<User> ListUsers()
    {
        return library.ListUsers();
    }
    public void CreateUser(string name, int age, string ssn, UserRole role)
    {
        library.CreateUser(name, age, ssn, role);
    }
    public void DeleteUser(string ssn)
    {
        library.DeleteUser(ssn);
    }
    public void UpdateUser(string ssn, string name, int age)
    {
        library.UpdateUser(ssn, name, age);
    }
}