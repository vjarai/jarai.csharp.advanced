using System.Globalization;
using System.Reflection;
using System.Resources;

[assembly: NeutralResourcesLanguage("de-DE")]

namespace Jarai.Globalization.Resources
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine(Thread.CurrentThread.CurrentCulture.Name);
            //var rm = new ResourceManager("strings", typeof(Program).Assembly);

            var ci = new CultureInfo("de-DE");
            var resourceManager = new ResourceManager("Resources.strings", Assembly.GetExecutingAssembly());

            //var bodyResource = resourceManager.GetString("TimeHeader", ci);
            var y = Properties.Resources.ResourceManager.GetString("strings_de_DE");

            //var x = rm.GetString("greeting");
        }
    }
}