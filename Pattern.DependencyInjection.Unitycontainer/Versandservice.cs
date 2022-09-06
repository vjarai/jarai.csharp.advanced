namespace Jarai.CSharp.Pattern.DependencyInjection.Unitycontainer
{
    public class Versandservice
    {
        public Versandservice(Logger logger)
        {
            Logger = logger;
        }

        public Logger Logger { get; set; }
    }
}