namespace Jarai.CSharp.Pattern.DependencyInjection.Unitycontainer
{
    public class Buchhaltung
    {
        public Buchhaltung(Logger logger)
        {
            Logger = logger;
        }

        public Logger Logger { get; set; }
    }
}