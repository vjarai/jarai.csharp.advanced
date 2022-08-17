using System;

namespace Jarai.Refresher.Relations
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ausflug mit (B)us oder (L)kw?");
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input)) return;

            Kfz meinFahrzeug;

            if (input.ToUpper() == "B")
                meinFahrzeug = new Bus("Deutz");
            else
                meinFahrzeug = new Lkw("MAN");

            // Spätes binden (Late Binding)
            // Zur *LAUFZEIT* wird entschieden ob Bus.Anzeigen() oder Lkw.Anzeigen() aufgerufen wird
            meinFahrzeug.Anzeigen();

            // Spätes binden (Late Binding)
            // Zur *LAUFZEIT* wird entschieden ob Bus.Fahren() oder Lkw.Fahren() aufgerufen wird
            meinFahrzeug.Fahren();

            // Vorsicht: Eine solche Typabfrage ist häufig ein Hinweis auf einen Designfehler!
            if (meinFahrzeug is Lkw)
            {
                var lkw = meinFahrzeug as Lkw;
                lkw.Beladen();
                lkw.Anzeigen();
            }

            Console.ReadLine();
        }
    }
}