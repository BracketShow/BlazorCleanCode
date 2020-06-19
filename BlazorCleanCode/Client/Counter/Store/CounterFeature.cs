using Fluxor;

namespace BlazorCleanCode.Client.Counter.Store
{
    public class CounterFeature : Feature<CounterState>
	{
		public override string GetName() => "Counter";

		protected override CounterState GetInitialState() =>
			new CounterState(numberOfClicks: 0);
	}
}
