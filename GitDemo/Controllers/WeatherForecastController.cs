using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GitDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            string repositoryUrl = "https://gitee.com/vuejs/core.git";
            string localPath = Path.Combine(Directory.GetCurrentDirectory(), "repo");
            string username = Environment.GetEnvironmentVariable("GitHubUsername");
            string password = Environment.GetEnvironmentVariable("GitHubPassword");

            // ¿ËÂ¡²Ö¿â
            ExecuteCmdCommand($"dir");

            return "Ö´ÐÐÍê±Ï";
        }

        private static void ExecuteCmdCommand(string command)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = "git",
                    Arguments = "clone https://gitee.com/vuejs/core.git ./core",
                }
            };
            process.Start();
        }
    }
}
