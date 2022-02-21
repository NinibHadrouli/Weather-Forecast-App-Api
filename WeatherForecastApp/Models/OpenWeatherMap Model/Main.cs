using System.ComponentModel.DataAnnotations;

namespace WeatherForecastApp.Models.OpenWeatherMap_Model
{
    public class Main
    {
        public float Temp { get; set; }
        [Display(Name = "Feels like")]
        public float Feels_like { get; set; } 

        [Display(Name = "Min temp")]
        public float Temp_min { get; set; }

        [Display(Name = "Max temp")]
        public float Temp_max { get; set; }

        public int Pressure { get; set; }
        public int Humidity { get; set; }
    }
}
