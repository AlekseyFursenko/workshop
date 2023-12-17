namespace Domain.Model.ModelDto;

public class UserContactWithPhoneDto
{
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string Description { get; set; }
  public string[] Phones { get; set; }
}