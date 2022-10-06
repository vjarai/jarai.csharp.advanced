using System;

namespace Jarai.CSharp.Interface.Disposable
{
    internal class BusyIndicator : IDisposable
    {
        public BusyIndicator()
        {
            Console.WriteLine("Berechnung gestartet (Sanduhr an).");
            
            // Todo: Sanduhr anzeigen...
        }

        /// <summary>
        /// Die Dispose Methode wird IMMER automatisch beim verlassen des zugehörigen using Blocks aufgerufen.
        /// (Auch bei einer Exception!)
        /// </summary>
        public void Dispose()
        {
            Console.WriteLine("Berechnung beenden (Sanduhr aus).");

            // Todo: Sanduhr ausblenden...
        }
    }
}