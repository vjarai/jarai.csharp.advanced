namespace Pattern6.DependencyInjection.Core
{
    public class NullLogger : ILogger
    {
        public void Write(string message)
        {
            // Nichts zu tun
        }
    }
}