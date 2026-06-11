namespace DemoApi.Tests;

public class WeatherForecastTests
{
    [Fact]
    public void TemperatureF_ConvertsFromCelsius()
    {
        var forecast = new WeatherForecast { TemperatureC = 0 };

        Assert.Equal(32, forecast.TemperatureF);
    }

    [Theory]
    [InlineData(100, 211)]   // truncation: (int)(100/0.5556) = 179, +32 = 211
    [InlineData(-40, -39)]   // truncation: (int)(-40/0.5556) = -71, +32 = -39
    [InlineData(37, 98)]
    public void TemperatureF_KnownValues(int celsius, int expectedFahrenheit)
    {
        var forecast = new WeatherForecast { TemperatureC = celsius };

        Assert.Equal(expectedFahrenheit, forecast.TemperatureF);
    }

    [Fact]
    public void Date_IsDateOnly()
    {
        var date = new DateOnly(2026, 1, 15);
        var forecast = new WeatherForecast { Date = date };

        Assert.Equal(date, forecast.Date);
    }

    [Fact]
    public void Summary_IsNullable()
    {
        var forecast = new WeatherForecast();

        Assert.Null(forecast.Summary);
    }

    [Fact]
    public void Demo_IsNullable()
    {
        var forecast = new WeatherForecast();

        Assert.Null(forecast.Demo);
    }
}
