using System;

namespace Jarai.CSharp.Patterns.DependencyInjection.Core
{
    public class RootApplication
    {
        private readonly ILogger _logger;

        public RootApplication(ILogger logger)
        {
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.Write($"RootApplication working at: {DateTime.Now}");
        }
    }
}