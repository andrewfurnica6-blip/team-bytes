namespace TeamBytes;

public abstract class User
{
    public string name { get; private set; }
    public int age { get; private set; }
    public string ssn { get; private set; }

    public User(string name, int age, string ssn, UserRole role)
    {
        this.name = name;
        this.age = age;
        this.ssn = ssn;
    }

    public void UpdateInfo(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}