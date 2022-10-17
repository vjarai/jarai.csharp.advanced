using System;

namespace Jarai.CSharp.Pattern.Observer
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var tesla = new Aktie("TESLA", "TESLA", 100);
          
            // Börse handelt mit diesen Aktien
            var börse = new Börse("NYSE", new Aktie[] { tesla });

            var anleger1 = new Beobachter("Aktienkäufer");
            var anleger2 = new Beobachter("Aktienverkäufer");

            // Anleger abonnieren Kursänderungen
            tesla.KursChanged += anleger1.PrüfeKauf; 
            tesla.KursChanged += anleger2.PrüfeVerkauf; 

            // Kurse ändern sich => Abonnenten werden benachrichtigt
            börse.AktualisiereKurse();

            Console.ReadLine();
        }
    }
}