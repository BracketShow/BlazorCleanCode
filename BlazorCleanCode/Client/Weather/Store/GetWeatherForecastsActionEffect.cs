using BlazorCleanCode.Client.Weather.Services;
using Fluxor;
using System.Threading.Tasks;

namespace BlazorCleanCode.Client.Weather.Store
{
    public class GetWeatherForecastsActionEffect
	{
		private readonly IWeatherService weatherService;

        public GetWeatherForecastsActionEffect(IWeatherService weatherService)
		{
            this.weatherService = weatherService;
        }

		[EffectMethod]
		public async Task HandleGetWeatherForecastsAction(GetWeatherForecastsAction action, IDispatcher dispatcher)
		{
			var forecasts = await weatherService.GetUpcomingFiveDaysWeatherForecasts();
			dispatcher.Dispatch(new GetWeatherForecastsResultAction(forecasts));
		}
	}
}
