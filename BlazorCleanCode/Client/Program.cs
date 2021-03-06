using System;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorCleanCode.Client.Typescript;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Fluxor;
using BlazorCleanCode.Client.Weather.Services;

namespace BlazorCleanCode.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<IUrlOpener, UrlOpener>();
            builder.Services.AddTransient<IWeatherService, WeatherService>();

            var currentAssembly = typeof(Program).Assembly;
            builder.Services.AddFluxor(options => options.ScanAssemblies(currentAssembly));

            await builder.Build().RunAsync();
        }
    }
}
