using Jarai.CSharp.Pattern.DependencyInjection.HomeBrew.Logging;

namespace Jarai.CSharp.Pattern.DependencyInjection.HomeBrew.Application
{
    public class Buchhaltung
    {
        private readonly KontoFactory _factory;

        public Buchhaltung(ILogger logger, KontoFactory factory)
        {
            _factory = factory;
            Logger = logger;

            Konto = _factory.CreateKonto();
        }

        public object Konto { get; set; }

        public ILogger Logger { get; set; }
    }
}