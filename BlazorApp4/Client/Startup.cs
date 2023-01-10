using BlazorApp4.Client.Interfaces;
using BlazorApp4.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorApp4.Client
{
    public class Startup
    {
        public static WebAssemblyHostBuilder InitializeApp(String[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            Configure(builder);
            ConfigureServices(builder);
            return builder;
        }
        private static void ConfigureServices(WebAssemblyHostBuilder builder)
        {
            //    builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<IPersonService, PersonService>();
        }

        private static void Configure(WebAssemblyHostBuilder builder)
        {
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");
        }
    }
}
