namespace Jarai.CSharp.Pattern.DependencyInjection.Unitycontainer
{
    public class Bestellservice
    {
        public Bestellservice(Logger logger)
        {
            Logger = logger;
        }

        public Logger Logger { get; set; }
    }
}