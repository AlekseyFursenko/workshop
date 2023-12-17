using System.Text.Json.Serialization;

namespace Domain.Model.Contacts;

public class Telephone
{
  public int Id { get; set; }
  public string Text { get; set; }
  public string Description { get; set; }
  [JsonIgnore]
  public UserContact Username { get; set; }
  public DateTime TimeCreated { get; set; }
  public Guid UsernameId { get; set; }

  public Telephone()
  {
    TimeCreated = DateTime.UtcNow;
  }
}