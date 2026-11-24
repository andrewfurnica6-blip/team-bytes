namespace TeamBytes;

public class Borrower : User
{
    public Borrower(string name, int age, string ssn) : base(name, age, ssn, UserRole.Borrower)
    {
    }

    public void Borrow(Media item)
    {
        item.Borrow(this);
    }

    public void rate(Media item, int score)
    {
        item.Rate(this, score);
    }
}