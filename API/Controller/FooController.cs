using Domain.Model.Service;
using Domain.Model.Weather;
using Microsoft.AspNetCore.Mvc;

namespace API.Controller;

public class FooController : BaseControllerApp
{
  private readonly IFoo foo1;
  private readonly IFoo foo2;

  public FooController(IFoo foo1, IFoo foo2)
  {
    this.foo1 = foo1;
    this.foo2 = foo2;
  }

  [HttpGet("Get1")]
  public string Get1()
  {
    return $"foo1: {foo1.GetCount()} foo2:{foo2.GetCount()}";
  }

  [HttpGet("Get2")]
  public string Get2()
  {
    return $"foo1: {foo1.GetCount()} foo2:{foo2.GetCount()}";
  }
}
