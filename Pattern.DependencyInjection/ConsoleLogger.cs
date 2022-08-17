using System;

namespace Pattern6.DependencyInjection.Core
{
    public class ConsoleLogger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine($"ConsoleLogger.Write(message: \"{message}\")");
        }
    }
}