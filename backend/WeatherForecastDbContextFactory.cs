using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace backend;

public class WeatherForecastDbContextFactory : IDesignTimeDbContextFactory<WeatherForecastDbContext>
{
    public WeatherForecastDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<WeatherForecastDbContext>();
        optionsBuilder.UseNpgsql("Host=localhost;Database=didactic;Username=didactic;Password=didactic;");

        return new WeatherForecastDbContext(optionsBuilder.Options);
    }
}
