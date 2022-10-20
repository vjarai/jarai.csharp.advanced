using Jarai.CSharp.Pattern.DependencyInjection.HomeBrew.Application;
using Jarai.CSharp.Pattern.DependencyInjection.HomeBrew.Container;
using Jarai.CSharp.Pattern.DependencyInjection.HomeBrew.Logging;

namespace Jarai.CSharp.Pattern.DependencyInjection.HomeBrew
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // var app =  CreateApp();

            var app = CreateAppViaIoC();
            app.Run();
        }

        /// <summary>
        /// Erstellt das Composition Root Object und alle Abhängigkeiten via einen IoC Container
        /// </summary>
        private static Applikation CreateAppViaIoC()
        {
            var container = new SimpleIocContainer();

            container.Register<ILogger, ConsoleLogger>();

            // Composition Root Object via IoC erstellen, => Alle Abhängigkeiten ("HAT EIN") werden automatisch aufgelöst
            var app = container.Resolve<Applikation>();
            return app;
        }


        /// <summary>
        /// Erstellt die Anwendung aus den einzelnen Komponenten 
        /// </summary>
        private static Applikation CreateApp()
        {
            var logger = new ConsoleLogger();
            var kontoFactory = new KontoFactory();
            var buchhaltung = new Buchhaltung(logger, kontoFactory);
            var einkauf = new Bestellservice(logger);
            var versand = new Versandservice(logger);
            var lager = new Lagerverwaltung(einkauf, versand);
            var viewModel = new ViewModel(lager, buchhaltung);
            var userInterface = new UserInterface(viewModel);
            var app = new Applikation(userInterface);

            return app;
        }
    }
}