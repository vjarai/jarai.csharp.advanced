using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Jarai.CSharp.Patterns.DependencyInjection.Core
{
    // Quelle:
    // https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection


    internal class Program
    {
        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                    services.AddHostedService<Worker>()
                        .AddScoped<ILogger, ConsoleLogger>());
            //.AddScoped<ILogger, NullLogger>());
        }

        private static Task Main(string[] args)
        {
            return CreateHostBuilder(args).Build().RunAsync();
        }
    }
}