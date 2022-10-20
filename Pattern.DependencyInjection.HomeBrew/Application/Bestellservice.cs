using Jarai.CSharp.Pattern.DependencyInjection.HomeBrew.Logging;

namespace Jarai.CSharp.Pattern.DependencyInjection.HomeBrew.Application
{
    public class Bestellservice
    {
        public Bestellservice(ConsoleLogger logger)
        {
            Logger = logger;
        }

        public ILogger Logger { get; set; }
    }
}