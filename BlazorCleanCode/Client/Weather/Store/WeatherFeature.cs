using Fluxor;

namespace BlazorCleanCode.Client.Weather.Store
{
    public class WeatherFeature : Feature<WeatherState>
	{
		public override string GetName() => "Weather";

		protected override WeatherState GetInitialState() =>
			WeatherState.MakeStateWith(null);
	}
}
