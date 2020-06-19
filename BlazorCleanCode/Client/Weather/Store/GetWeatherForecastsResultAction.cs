using BlazorCleanCode.Shared;
using System.Collections.Generic;

namespace BlazorCleanCode.Client.Weather.Store
{
    public class GetWeatherForecastsResultAction
    {
        public IEnumerable<WeatherForecast> Forecasts { get; }

        public GetWeatherForecastsResultAction(IEnumerable<WeatherForecast> forecasts)
        {
            Forecasts = forecasts;
        }
    }
}
