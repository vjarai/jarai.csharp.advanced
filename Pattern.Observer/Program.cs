using System;

namespace Jarai.CSharp.Patterns.Observer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var tesla = new AktieWithEvent("TESLA", "TESLA", 100);
            var msft = new AktieWithCallbackDelegate("MSFT", "Microsoft", 50);
            var dax = new AktieWithCallbackFunc("DAX", "DAX", 200);

            var börse = new Börse("NYSE", new Aktie[] { tesla, msft, dax });

            var anleger1 = new Beobachter("Anleger1");
            var anleger2 = new Beobachter("Anleger2");

            tesla.KursChanged += anleger1.PrüfeKauf;
            msft.Callbacks.Add(anleger2.PrüfeKauf);
            dax.Callbacks.Add(anleger2.PrüfeVerkauf);

            börse.AktualisiereKurse();

            Console.ReadLine();
        }
    }
}