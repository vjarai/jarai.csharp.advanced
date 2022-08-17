using System;

namespace Jarai.Generic.LazyLoad
{
    internal class Program
    {
        private static int LongRunningCalculation()
        {
            Console.WriteLine("Der Wert wird nur beim ersten Zugriff geladen/berechnet.");
            return 42;
        }

        private static void Main(string[] args)
        {
            var x = new LazyLoaded<int>(LongRunningCalculation);

            Console.WriteLine(x.Value);
            Console.WriteLine(x.Value);
        }
    }
}