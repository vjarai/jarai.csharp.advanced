using Unity;

namespace Jarai.CSharp.Pattern.DependencyInjection.Unitycontainer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /* Code OHNE IoC Container
            var logger = new Logger();
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

            var container = new UnityContainer();
            var app2 = container.Resolve<Applikation>();
            app2.Run();
        }
    }
}