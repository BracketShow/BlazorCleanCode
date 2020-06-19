using BlazorCleanCode.Shared;
using System.Threading.Tasks;

namespace BlazorCleanCode.Client.Weather.Services
{
    public interface IWeatherService
    {
        Task<WeatherForecast[]> GetUpcomingFiveDaysWeatherForecasts();
    }
}
