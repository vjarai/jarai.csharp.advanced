using System;
using System.Diagnostics;

namespace Jarai.CSharp.Pattern.DependencyInjection.Unitycontainer
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