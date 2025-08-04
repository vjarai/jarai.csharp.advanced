using Microsoft.Extensions.DependencyInjection;

namespace Jarai.CSharp.Patterns.DependencyInjection.Core
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the IoC Container
            var serviceCollection = new ServiceCollection();

            // Register service implementations with the IoC Container
#if DEBUG
            serviceCollection.AddTransient<ILogger, ConsoleLogger>();
#else
            services.AddTransient<ILogger, NullLogger>();
#endif
            serviceCollection.AddSingleton<RootApplication>();

            // Create a service provider to instantiate objects and resolve their dependencies
            using var serviceProvider = serviceCollection.BuildServiceProvider();

            // Resolve the composition root object (including all injected dependencies)
            var applicationRoot = serviceProvider.GetRequiredService<RootApplication>();

            // Use the composition root object
            applicationRoot.DoWork();
        }

    }
}