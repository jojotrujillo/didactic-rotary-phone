using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return GetWeatherForecast().Result;
    }

    protected async Task<IEnumerable<WeatherForecast>> GetWeatherForecast()
    {
        string connectionString = "Host=localhost;Database=didactic;Username=didactic;Password=didactic;";
        await using var dataSource = NpgsqlDataSource.Create(connectionString);
        await using var command = dataSource.CreateCommand("SELECT * FROM public.\"WeatherForecasts\"");
        await using var reader = await command.ExecuteReaderAsync();
        List<WeatherForecast> list = new List<WeatherForecast>();

        while (await reader.ReadAsync())
        {
            DateTime? date = reader["Date"] as DateTime?;
            int? temperatureC = reader["TemperatureC"] as int?;
            string? summary = reader["Summary"] as string;

            list.Add(new WeatherForecast
            {
                Date = date.Value,
                TemperatureC = temperatureC.Value,
                Summary = summary
            });
        }

        return await Task.FromResult(list);
    }
}
