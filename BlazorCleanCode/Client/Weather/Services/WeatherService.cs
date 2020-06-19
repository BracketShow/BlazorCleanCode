using BlazorCleanCode.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorCleanCode.Client.Weather.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient httpClient;

        public WeatherService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<WeatherForecast[]> GetUpcomingFiveDaysWeatherForecasts()
        {
            return await httpClient.GetFromJsonAsync<WeatherForecast[]>(
                WeatherApiRoutes.GetUpcomingFiveDaysWeatherForecasts);
        }
    }
}
