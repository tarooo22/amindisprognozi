using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecast.Models;
using WeatherForecast.Services;

namespace WeatherForecast.ViewComponents
{
    public class ForecastInformationViewComponent : ViewComponent
    {
        private readonly IConfiguration _config;
        private readonly ForecastService _forecastService;

        public ForecastInformationViewComponent(IConfiguration config)
        {
            _config = config;
            _forecastService = new ForecastService();
        }
        public IViewComponentResult Invoke(string city)
        {
            string query = "https://api.openweathermap.org/data/2.5/forecast?q=+" + city + "&units=metric&appid=" + _config.GetValue<string>("WeatherForcastAPIKey");
            WeatherForecastData weatherData = _forecastService.GetWeatherForecast(query).Result;
            return View(weatherData);
        }
    }
}
