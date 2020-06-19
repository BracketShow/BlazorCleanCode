using BlazorCleanCode.Client.Counter.Store;
using BlazorCleanCode.Client.Typescript;
using Fluxor;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorCleanCode.Client.Counter.Pages
{
    public partial class Counter
    {
        [Inject]
        private IState<CounterState> CounterState { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        private void IncrementCount()
        {
            Dispatcher.Dispatch(new IncrementCounterAction());
        }

        private void OpenExternalLink()
        {
            UrlOpener.OpenExternalLink(JSRuntime, "test");
        }
    }
}