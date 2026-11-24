namespace TeamBytes;

public class Library
{
  private List<Media> mediaItems = new List<Media>();
  private List<User> users = new List<User>();

  public void AddMedia(Media media)
  {
    mediaItems.Add(media);
  }

  public void RemoveMedia(int Id)
  {
    Media? media = FindMedia(Id);
    if (media != null)
    {
      mediaItems.Remove(media);
    }
  }

  public Media? FindMedia(int id)
  {
    foreach (Media media in mediaItems)
    {
      if (media.Id == id)
      {
        return media;
      }
    }
    return null;
  }

  public List<Media> ListByType(Type type)
  {
    List<Media> result = new List<Media>();
    foreach (Media media in mediaItems)
    {
      if(media.GetType()==type){
        result.Add(media);
      }
    }
    return result;
  }

  public void AddUser(User user)
  {
    users.Add(user);
  }

  public void RemoveUser(string ssn)
  {
    User? user = FindUser(ssn);
    if (user != null)
    {
      users.Remove(user);
    }
  }

  public User? FindUser(string ssn)
  {
    foreach (User user in users)
    {
      if (user.ssn == ssn)
      {
        return user;
      }
    }
    return null;
  }
  public List<User> ListUsers()
  {
    return users;
  }
}