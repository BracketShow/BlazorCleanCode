using Fluxor;

namespace BlazorCleanCode.Client.Counter.Store
{
    public static class CounterReducers
    {
        [ReducerMethod]
        public static CounterState ReduceIncrementCounterAction(
            CounterState state, IncrementCounterAction action) =>
            CounterState.MakeStateWithNumberOfClicks(state.NumberOfClicks + 1);
    }
}
