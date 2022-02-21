using WeatherForecastApp.Models.OpenWeatherMap_Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;


namespace WeatherForecastApp.Repositories
{
    public class WForecastRepository : IWForecastRepository
    {
        public WeatherResponse GetForecast(string city)
        {
            string APP_ID = Configration.Values.OPEN_WEATHER_APP_AD;
            var client = new RestClient($"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={APP_ID}");

            var request = new RestRequest();
            var response= client.GetAsync(request).Result;
            // var  response= client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                var content =JsonConvert.DeserializeObject<JToken>(response.Content);
                return content?.ToObject<WeatherResponse>();
            }
            else
            {
             return null;
            }
        }
    }
}
