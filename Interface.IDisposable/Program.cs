using System;
using System.Threading;

namespace Jarai.CSharp.Interface.Disposable
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            using (new BusyIndicator()) // Sanduhr
            {
                Console.WriteLine("Berechne Ergebnis...");
                Thread.Sleep(3000);


                // Beim verlassen dieses Using Blocks wird immer und 
                // automatisch BusyIndicator.Dispose() aufgerufen,
                // (auch im Falle einer Exception!)
            }

            Console.ReadLine();
        }
    }
}