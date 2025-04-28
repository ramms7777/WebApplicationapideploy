using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace WebApplicationapideploy.Controllers
{
    [ApiController]
    [Route("qumuli")] // 💡 Always lowercase route for Linux containers
    public class QumuliController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Qumulihasan", "Qumulikishore", "Qumulirun", "Qumuliscan", "Mild", "Qumulistear", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<QumuliController> _logger;

        public QumuliController(ILogger<QumuliController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = Enumerable.Range(5, 50).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index + 2)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            });

            return Ok(result);
        }
    }
}
