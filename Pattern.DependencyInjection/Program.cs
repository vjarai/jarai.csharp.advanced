using Microsoft.Extensions.DependencyInjection;

namespace Jarai.CSharp.Patterns.DependencyInjection.Core
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the IoC Container
            var serviceCollection = new ServiceCollection();

            // Register services
#if DEBUG
            serviceCollection.AddTransient<ILogger, ConsoleLogger>();
#else
            services.AddTransient<ILogger, NullLogger>();
#endif
            serviceCollection.AddSingleton<RootApplication>();
            
            // Create the service provider
            using var serviceProvider = serviceCollection.BuildServiceProvider();

            // Resolve and use the composition root object with injected dependencies
            var applicationRoot = serviceProvider.GetRequiredService<RootApplication>();

            // Use the root object
            applicationRoot.DoWork();
        }

    }
}