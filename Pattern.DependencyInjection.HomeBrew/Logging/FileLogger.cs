using System.Diagnostics;

namespace Jarai.CSharp.Pattern.DependencyInjection.HomeBrew.Logging
{
    class FileLogger : ILogger
    {
        public void Write(string msg)
        {

        }

        public FileLogger()
        {
            Debug.WriteLine("Logger Instanz erstellt.");
        }
    }
}