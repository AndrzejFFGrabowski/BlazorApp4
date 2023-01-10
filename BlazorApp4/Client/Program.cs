using BlazorApp4.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorApp4.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = Startup.InitializeApp(args);
            await builder.Build().RunAsync();
        }
    }
}