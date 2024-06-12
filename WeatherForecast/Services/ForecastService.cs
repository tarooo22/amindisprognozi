using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherForecast.Models;

namespace WeatherForecast.Services
{
    public class ForecastService
    {
        readonly HttpClient _client;


        public ForecastService()
        {
            _client = new HttpClient();
        }

        public async Task<WeatherData> GetWeatherData(string query)
        {
            WeatherData weatherData = null;
            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    weatherData = JsonConvert.DeserializeObject<WeatherData>(content);
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return weatherData;
        }

        public async Task<WeatherForecastData> GetWeatherForecast(string query)
        {
            WeatherForecastData weatherData = null;
            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    weatherData = JsonConvert.DeserializeObject<WeatherForecastData>(content);
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return weatherData;
        }
    }
}
