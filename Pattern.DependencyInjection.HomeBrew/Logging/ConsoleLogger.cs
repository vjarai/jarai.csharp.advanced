using System.Diagnostics;

namespace Jarai.CSharp.Pattern.DependencyInjection.HomeBrew.Logging
{
    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        {
            Debug.WriteLine("Logger Instanz erstellt.");
        }

        public void Write(string msg)
        {
            Debug.WriteLine(msg);
        }
    }
}