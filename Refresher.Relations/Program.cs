namespace Jarai.CSharp.Advanced.Refresher.Relations
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Ausflug mit (P)kw oder (C)abrio?");
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input)) return;

            var meinPkw = new Pkw("VW Golf", new Motor(100));
            var meinCabrio = new Cabrio("BMW Z3", new Motor(100));

            Pkw aktuellesFahrzeug;

            if (input.ToUpper() == "P")
                aktuellesFahrzeug = meinPkw;
            else
                aktuellesFahrzeug = meinCabrio;

            // Spätes binden (Late Binding)
            // Zur *LAUFZEIT* wird entschieden ob Lkw.Anzeigen() oder Cabrio.Anzeigen() aufgerufen wird
            Console.WriteLine( aktuellesFahrzeug.ToString());

            // Spätes binden (Late Binding)
            // Zur *LAUFZEIT* wird entschieden ob Lkw.Fahren() oder Cabrio.Fahren() aufgerufen wird
            aktuellesFahrzeug.Fahren(100);

            // Vorsicht: Eine solche Typabfrage ist häufig ein Hinweis auf einen Designfehler!
            //if (aktuellesFahrzeug is Cabrio)
            //{
            //    var cabrio = aktuellesFahrzeug as Cabrio;
            //    cabrio.VerdeckÖffnen();
            //}

            Console.ReadLine();
        }
    }
}