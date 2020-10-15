using System.Threading.Tasks;
using BlazorCleanCode.Client.Weather.Store;
using BlazorCleanCode.Shared;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace BlazorCleanCode.Client.Weather.Pages
{
    public partial class Forecasts
    {
        private WeatherForecast newForecast = new WeatherForecast();

        [Inject]
        private IState<WeatherState> WeatherState { get; set; }

        [Inject]
        private IDispatcher Dispatcher { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            Dispatcher.Dispatch(new GetWeatherForecastsAction());
        }

        private void SubmitForecast()
        {
        }
    }
}