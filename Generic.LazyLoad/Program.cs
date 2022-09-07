using System;
using System.Threading;

namespace Jarai.CSharp.Generic.LazyLoad
{
    internal class Program
    {
        /// <summary>
        /// Wird nur aufgerufen wenn beim ersten mal auf x.Value zugegriffen wird.
        /// </summary>
        private static int SlowCalculation()
        {
            Console.WriteLine("Der Wert wird nur beim ersten Zugriff geladen/berechnet.");
            Thread.Sleep(1000); // simuliert eine langsame Berechnung
            return 42;
        }

        private static void Main(string[] args)
        {
            var x = new Lazy<int>(SlowCalculation);

            var eingabe = Console.ReadLine();

            if (eingabe != "skip")
            {
                Console.WriteLine(x.Value);
                Console.WriteLine(x.Value);
            }
        }
    }
}