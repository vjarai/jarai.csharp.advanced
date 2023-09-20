using System;

namespace Jarai.CSharp.Interface.Disposable
{
    internal class BusyIndicator : IDisposable
    {
        public BusyIndicator()
        {
            Console.WriteLine("Berechnung gestartet (Sanduhr an).");
        }


        public void Dispose()
        {
            Console.WriteLine("Sanduhr aus.");
        }
    }
}