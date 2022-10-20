using System;

namespace Jarai.CSharp.Patterns.DependencyInjection.Core
{
    public class ConsoleLogger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine($"ConsoleLogger.Write(message: \"{message}\")");
        }
    }
}