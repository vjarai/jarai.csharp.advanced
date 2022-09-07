using System.Diagnostics;

namespace Jarai.CSharp.Pattern.DependencyInjection.Unitycontainer
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