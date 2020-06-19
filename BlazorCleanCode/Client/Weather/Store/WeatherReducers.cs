using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCleanCode.Client.Weather.Store
{
    public static class WeatherReducers
    {
        [ReducerMethod]
        public static WeatherState ReduceGetWeatherForecastsAction(WeatherState state, GetWeatherForecastsAction action) =>
            WeatherState.MakeLoadingState();

        [ReducerMethod]
        public static WeatherState ReduceGetWeatherForecastsResultAction(WeatherState state, GetWeatherForecastsResultAction action) =>
            WeatherState.MakeStateWith(action.Forecasts);
    }
}
