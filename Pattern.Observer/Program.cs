using System;

namespace Jarai.CSharp.Pattern.Observer
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var tesla = new Aktie("TESLA", "TESLA", 100);

            var anleger1 = new Beobachter("Aktienkäufer");
            var anleger2 = new Beobachter("Aktienverkäufer");

            // Anleger abonnieren Kursänderungen
            tesla.KursChanged += anleger1.PrüfeKauf; 
            tesla.KursChanged += anleger2.PrüfeVerkauf; 

            // Kurs ändert sich => Abonnenten werden benachrichtigt
            tesla.AktuellerKurs = 200;

            Console.ReadLine();
        }
    }
}