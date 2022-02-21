using WeatherForecastApp.Models.OpenWeatherMap_Model;

namespace WeatherForecastApp.Repositories
{
    public interface IWForecastRepository
    {
        WeatherResponse GetForecast(string city);
    }
}
