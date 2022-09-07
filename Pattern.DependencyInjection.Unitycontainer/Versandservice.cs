namespace Jarai.CSharp.Pattern.DependencyInjection.Unitycontainer
{
    public class Versandservice
    {
        public Versandservice(ConsoleLogger logger)
        {
            Logger = logger;
        }

        public ILogger Logger { get; set; }
    }
}