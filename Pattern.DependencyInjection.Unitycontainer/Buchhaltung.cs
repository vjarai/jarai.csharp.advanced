namespace Jarai.CSharp.Pattern.DependencyInjection.Unitycontainer
{
    public class Buchhaltung
    {
        private readonly KontoFactory _factory;

        public Buchhaltung(ConsoleLogger logger, KontoFactory factory)
        {
            _factory = factory;
            Logger = logger;

            Konto = _factory.CreateKonto();
        }

        public object Konto { get; set; }

        public ILogger Logger { get; set; }
    }
}