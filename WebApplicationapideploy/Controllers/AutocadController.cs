using Microsoft.AspNetCore.Mvc;

namespace WebApplicationapideploy.Controllers;

[ApiController]
[Route("autocad")]
public class AutoCADController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<AutoCADController> _logger;

    public AutoCADController(ILogger<AutoCADController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "AutoCAD")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(5, 50).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index + 2)),
            TemperatureC = Random.Shared.Next(-20, 5500),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
