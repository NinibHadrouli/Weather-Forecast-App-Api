using Microsoft.AspNetCore.Mvc;
using WeatherForecastApp.Models;
using WeatherForecastApp.Models.OpenWeatherMap_Model;
using WeatherForecastApp.Repositories;

namespace WeatherForecastApp.Controllers
{
    public class WeatherForecastController : Controller
    {
        private readonly IWForecastRepository _WForecastRepository;
        public WeatherForecastController(IWForecastRepository WForecastRepository)
        {
            _WForecastRepository= WForecastRepository;
        }
        [HttpGet]
        public IActionResult SearchByCity()
        {
            var viweModel = new SearchByCity();
            return View(viweModel);
        }
        [HttpPost]
        public IActionResult SearchByCity(SearchByCity model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("City", "WeatherForecast", new { city=model.CityName });
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult City(string city)
        {
            ViewData["GetCity"]=city;
                City viewModel = new City();
            if (city != null)
            {


                WeatherResponse weatherResponse = _WForecastRepository.GetForecast(city);
                if (weatherResponse != null)
                {
                    viewModel.Name = weatherResponse.Name;
                    viewModel.Temprature = weatherResponse.Main.Temp;
                    viewModel.Humidity = weatherResponse.Main.Humidity;
                    viewModel.Pressure = weatherResponse.Main.Pressure;
                    viewModel.Feels_like = weatherResponse.Main.Feels_like;
                    viewModel.Weather = weatherResponse.Weather[0].Main;
                    viewModel.Wind = weatherResponse.Wind.Speed;

                }
                return View(viewModel);
            }
            else {
               
                return View(viewModel); 
            }
        }

       
    }
}
