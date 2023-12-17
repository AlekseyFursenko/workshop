using Domain.Model.Weather;
using Microsoft.AspNetCore.Mvc;

namespace API.Controller
{
  [ApiController]
  [Route("api/[controller]")]
  public class WeatherForecastController : ControllerBase
  {

    string[] summaries = new[]
    {
        "Freezing", "Bracing",
        "Chilly", "Cool", "Mild",
        "Warm", "Balmy", "Hot",
        "Sweltering", "Scorching"
    };

    [HttpGet]
    public WeatherForecast[] Get()
    {
      var forecast = Enumerable.Range(1, 5).Select(index =>
       new WeatherForecast
       (
           DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
           Random.Shared.Next(-20, 55),
           summaries[Random.Shared.Next(summaries.Length)]
       ))
       .ToArray();
      return forecast;
    }

    [HttpPost]
    public WeatherForecast[] Post()
    {
      var forecast = Enumerable.Range(1, 5).Select(index =>
       new WeatherForecast
       (
           DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
           Random.Shared.Next(-20, 55),
           summaries[Random.Shared.Next(summaries.Length)]
       ))
       .ToArray();
      return forecast;
    }
  }
}