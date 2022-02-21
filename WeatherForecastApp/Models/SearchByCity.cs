using System.ComponentModel.DataAnnotations;

namespace WeatherForecastApp.Models
{
    public class SearchByCity
    {
        [Required(ErrorMessage = "City name is empty")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Invaild Input")]
        public string CityName { get; set; }
    }
}
