using System;

namespace Jarai.CSharp.Pattern.Observer
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var tesla = new AktieWithEvent("TESLA", "TESLA", 100);
            var msft = new AktieWithCallbackDelegate("MSFT", "Microsoft", 50);
            var dax = new AktieWithCallbackFunc("DAX", "DAX", 200);

            // Börse handelt mit diesen Aktien
            var börse = new Börse("NYSE", new Aktie[] { tesla, msft, dax });

            var anleger1 = new Beobachter("Aktienkäufer");
            var anleger2 = new Beobachter("Aktienverkäufer");

            // Anleger abonnieren Kursänderungen
            tesla.KursChanged += anleger1.PrüfeKauf; // Events ist Best Practice
            tesla.KursChanged -= anleger1.PrüfeKauf; // Events ist Best Practice

            msft.Callbacks.Add(anleger2.PrüfeKauf);  // Delegates sind im Prinzip "veraltet"
            dax.Callbacks.Add(anleger2.PrüfeVerkauf);// Action ist Nachfolger von Delegate 

            // Kurse ändern sich => Abonnenten werden benachrichtigt
            börse.AktualisiereKurse();

            Console.ReadLine();
        }
    }
}