using System.ComponentModel.DataAnnotations;

namespace WeatherForecastApp.Models
{
    public class City
    {
        [Display(Name = "City Name:")]
        public string Name { get; set; }
        public float Temprature { get; set; }
        public int Humidity { get; set; }
        public int Pressure { get; set; }
        public float Feels_like { get; set; }
        public float Wind { get; set; }
        public string Weather { get; set; }

        public SearchByCity SearchByCity { get; set; }
    }
}
