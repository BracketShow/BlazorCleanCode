using BlazorCleanCode.Shared;
using System;
using System.Collections.Generic;

namespace BlazorCleanCode.Client.Weather.Store
{
    public class WeatherState
    {
		public bool IsLoading { get; }
		public IEnumerable<WeatherForecast> Forecasts { get; }

		public static WeatherState MakeLoadingState()
        {
			return new WeatherState(true, null);
        }

		public static WeatherState MakeStateWith(IEnumerable<WeatherForecast> forecasts)
        {
			return new WeatherState(false, forecasts);
        }

		private WeatherState(bool isLoading, IEnumerable<WeatherForecast> forecasts)
		{
			IsLoading = isLoading;
			Forecasts = forecasts ?? Array.Empty<WeatherForecast>();
		}
	}
}
