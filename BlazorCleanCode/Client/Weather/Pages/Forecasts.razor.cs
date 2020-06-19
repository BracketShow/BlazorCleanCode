using System.Threading.Tasks;
using BlazorCleanCode.Client.Weather.Store;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace BlazorCleanCode.Client.Weather.Pages
{
    public partial class Forecasts
    {
        [Inject]
        private IState<WeatherState> WeatherState { get; set; }

        [Inject]
        private IDispatcher Dispatcher { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            Dispatcher.Dispatch(new GetWeatherForecastsAction());
        }
    }
}