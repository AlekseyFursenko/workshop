using Domain.Model.NumbersModel;
using Microsoft.AspNetCore.Mvc;
using Persistance;

namespace API.Controller;

public class NumbersPairController : BaseControllerApp
{
  private readonly DataContext dataContext;

  public NumbersPairController(DataContext dataContext)
  {
    this.dataContext = dataContext;
  }

  [HttpGet(nameof(this.GetNumbersPairs))]
  public IEnumerable<NumbersPair> GetNumbersPairs()
  {
    return dataContext.Numbers.ToArray();
  }

  [HttpPut(nameof(this.AppendNumbersPairs))]
  public async Task<IActionResult> AppendNumbersPairs(NumbersPair numbersPair)
  {
    await dataContext.Numbers.AddAsync(numbersPair);
    var res = await dataContext.SaveChangesAsync();
    return Ok(res);
  }

}
