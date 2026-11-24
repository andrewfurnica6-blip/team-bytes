using System;
using System.Collections.Generic;
namespace TeamBytes;

abstract public class Media
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    private List<Borrower> borrowers=new List<Borrower>();
    private Dictionary<Borrower, int> ratings=new Dictionary<Borrower, int>();
    public bool isDownloaded { get; private set; }

    public double AverageRating
    {
        get
        {
            if (ratings.Count == 0)
            {
                return 0;
            }

            double total = 0;
            foreach (KeyValuePair<Borrower, int> rating in ratings)
            {
                total += rating.Value;
            }
            return total / ratings.Count;
        }
    }

    public Media(int id, string title)
    {
        this.Id = id;
        this.Title = title;
    }

    public void Borrow(Borrower borrower)
    {
        borrowers.Add(borrower);
    }

    public void Rate(Borrower borrower, int score)
    {
        ratings[borrower] = score;
    }

    public void Download()
    {
        isDownloaded = true;
    }

    public abstract string GetDetails();
}