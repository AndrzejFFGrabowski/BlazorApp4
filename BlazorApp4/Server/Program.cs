using BlazorApp4.Server;
using Microsoft.AspNetCore.ResponseCompression;

namespace BlazorApp4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = Startup.InitializeApp(args);
            
            app.Run();
        }
    }
}