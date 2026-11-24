namespace TeamBytes;

public class Employee:User
{
    protected Library library;
    public Employee(string name, int age, string ssn, Library library) : base(name, age, ssn, UserRole.Employee)
    {
        this.library = library;
    }

    public void AddMedia(Media media)
    {
        library.AddMedia(media);
    }

    public void RemoveMedia(int Id)
    {
        library.RemoveMedia(Id);
    }
}