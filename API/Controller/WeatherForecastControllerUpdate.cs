using Domain.Model.Weather;
using Microsoft.AspNetCore.Mvc;

namespace API.Controller
{
  public class WeatherForecastControllerUpdate : BaseControllerApp
  {

    string[] summaries = new[]
    {
        "Freezing", "Bracing",
        "Chilly", "Cool", "Mild",
        "Warm", "Balmy", "Hot",
        "Sweltering", "Scorching"
    };

    [HttpGet("GetCollectionWeatherForecast")]
    public IActionResult GetCollectionWeatherForecast()
    {
      var forecast = Enumerable.Range(1, 5).Select(index =>
       new WeatherForecast
       (
           DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
           Random.Shared.Next(-20, 55),
           summaries[Random.Shared.Next(summaries.Length)]
       ))
       .ToArray();
      return Created("", forecast);
    }

    [HttpGet("GetCollectionWeatherForecast/{start}/{end}")]
    public WeatherForecast[] GetCollectionWeatherForecast(int start = 0, int end = 2)
    {
      var forecast = Enumerable.Range(start, end).Select(index =>
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
    [Route("Post")]
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