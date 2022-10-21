using Jarai.CSharp.Pattern.DependencyInjection.HomeBrew.Logging;

namespace Jarai.CSharp.Pattern.DependencyInjection.HomeBrew.Application
{
    public class Versandservice
    {
        public Versandservice(ILogger logger)
        {
            Logger = logger;
        }

        public ILogger Logger { get; set; }
    }
}