using Domain.Model.Contacts;
using Domain.Model.ModelDto;
using Domain.Model.Weather;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistance;

namespace API.Controller
{
  public class ContactController : BaseControllerApp
  {
    private readonly DataContext dataContext;

    public ContactController(DataContext dataContext)
    {
      this.dataContext = dataContext;
    }

    [HttpGet(nameof(this.GetAllContact))]
    public async Task<IActionResult> GetAllContact()
    {
      var contacts = await dataContext
      .Contacts
      .Include(prop => prop.AllTelephones)
      .Select(item => new UserContactWithPhoneDto()
      {
        FirstName = item.FirstName,
        LastName = item.LastName,
        Description = item.Id.ToString(),
        Phones = item.AllTelephones.Select(e => e.Text).ToArray()
      })
      .ToListAsync();

      return Ok(contacts);
    }

    [HttpPost(nameof(this.AppendContactWithTelephone))]
    public async Task<IActionResult> AppendContactWithTelephone([FromBody] UserContactWithPhoneDto dto)
    {
      try
      {
        UserContact userContact = new()
        {
          FirstName = dto.FirstName,
          LastName = dto.LastName,
          Description = dto.Description,
          AllTelephones = dto.Phones.Select(
          phone => new Telephone() { Text = phone }
        ).ToList()
        };

        await dataContext.Contacts.AddAsync(userContact);
        await dataContext.SaveChangesAsync();
        return Ok(userContact);
      }
      catch (Exception ex)
      {
        return BadRequest($"Exception {ex}");
      }
    }

  }
}