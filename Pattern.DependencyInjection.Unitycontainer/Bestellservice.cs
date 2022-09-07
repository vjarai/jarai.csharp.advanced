namespace Jarai.CSharp.Pattern.DependencyInjection.Unitycontainer
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