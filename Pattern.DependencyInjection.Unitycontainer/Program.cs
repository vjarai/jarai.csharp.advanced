using Unity;
using Unity.Lifetime;

namespace Jarai.CSharp.Pattern.DependencyInjection.Unitycontainer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /* Code OHNE IoC Container
            var logger = new ConsoleLogger();
            var buchhaltung = new Buchhaltung(logger);
            var einkauf = new Bestellservice(logger);
            var versand = new Versandservice(logger);
            var lager = new Lagerverwaltung(einkauf,versand);
            var viewModel = new ViewModel( lager, buchhaltung );
            var userInterface = new UserInterface(viewModel);
            var app = new Applikation(userInterface);

            app.Run();
            */

            // Code mit IoC Container :-)

            // Step1: IoC Container erstellen
            var inversionOfControlContainer = new UnityContainer();

            // Step2: IoC Container im Code (oder per Config file) configurieren
            // inversionOfControlContainer.RegisterType<ILogger, FileLogger>();  // Jeder bekommt einen neue Logger Instanz

            // Variante: Als Logger als Singleton registrieren
            inversionOfControlContainer.RegisterInstance<ILogger>(new  ConsoleLogger(), new SingletonLifetimeManager());


            
            // Step3: Composition Root Object via IoC erstellen
            // => Alle Abhängigkeiten ("HAT EIN") werden automatisch aufgelöst
            var app2 = inversionOfControlContainer.Resolve<Applikation>();
            app2.Run();
        }
    }
}