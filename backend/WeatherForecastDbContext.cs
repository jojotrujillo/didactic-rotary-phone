using Microsoft.EntityFrameworkCore;

namespace backend;

public class WeatherForecastDbContext : DbContext
{
    public WeatherForecastDbContext(DbContextOptions<WeatherForecastDbContext> options) : base(options)
    {
    }

    public DbSet<WeatherForecast> WeatherForecasts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=didactic;Username=didactic;Password=didactic;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WeatherForecast>(entity =>
        {
            entity.HasKey(e => e.Date);
            entity.HasData(
            new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = 0,
                Summary = "Freezing"
            },
            new WeatherForecast
            {
                Date = DateTime.Now.AddDays(1),
                TemperatureC = 1,
                Summary = "Bracing"
            },
            new WeatherForecast
            {
                Date = DateTime.Now.AddDays(2),
                TemperatureC = 2,
                Summary = "Chilly"
            },
            new WeatherForecast
            {
                Date = DateTime.Now.AddDays(3),
                TemperatureC = 3,
                Summary = "Cool"
            },
            new WeatherForecast
            {
                Date = DateTime.Now.AddDays(4),
                TemperatureC = 4,
                Summary = "Mild"
            },
            new WeatherForecast
            {
                Date = DateTime.Now.AddDays(5),
                TemperatureC = 5,
                Summary = "Warm"
            },
            new WeatherForecast
            {
                Date = DateTime.Now.AddDays(6),
                TemperatureC = 6,
                Summary = "Balmy"
            },
            new WeatherForecast
            {
                Date = DateTime.Now.AddDays(7),
                TemperatureC = 7,
                Summary = "Hot"
            },
            new WeatherForecast
            {
                Date = DateTime.Now.AddDays(8),
                TemperatureC = 8,
                Summary = "Sweltering"
            },
            new WeatherForecast
            {
                Date = DateTime.Now.AddDays(9),
                TemperatureC = 9,
                Summary = "Scorching"
            });
        });
    }
}
