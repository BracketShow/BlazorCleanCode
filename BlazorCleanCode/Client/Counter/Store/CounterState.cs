namespace BlazorCleanCode.Client.Counter.Store
{
    public class CounterState
	{
		public int NumberOfClicks { get; }

		public static CounterState MakeStateWithNumberOfClicks(int numberOfClicks)
        {
			return new CounterState(numberOfClicks);
        }

		public CounterState(int numberOfClicks)
		{
			NumberOfClicks = numberOfClicks;
		}
	}
}
