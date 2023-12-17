namespace Domain.Model.Contacts;

public class UserContact
{
  public Guid Id { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string Description { get; set; }
  public DateTime TimeCreated { get; set; }
  public List<Telephone> AllTelephones { get; set; }
  public UserContact()
  {
    TimeCreated = DateTime.UtcNow;
  }
}
