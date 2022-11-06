namespace Jarai.CSharp.Advanced.Refresher.Relations
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ausflug mit (P)kw oder (L)kw?");
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input)) return;

            Kfz meinFahrzeug;

            if (input.ToUpper() == "P")
                meinFahrzeug = new Pkw("VW", new Motor(100));
            else
                meinFahrzeug = new Lkw("Deutz");

            // Spätes binden (Late Binding)
            // Zur *LAUFZEIT* wird entschieden ob Lkw.Anzeigen() oder Pkw.Anzeigen() aufgerufen wird
            Console.WriteLine( meinFahrzeug.ToString());

            // Spätes binden (Late Binding)
            // Zur *LAUFZEIT* wird entschieden ob Lkw.Fahren() oder Pkw.Fahren() aufgerufen wird
            meinFahrzeug.Fahren(100);

            // Vorsicht: Eine solche Typabfrage ist häufig ein Hinweis auf einen Designfehler!
            if (meinFahrzeug is Lkw)
            {
                var bus = meinFahrzeug as Lkw;
                bus.Beladen();
                Console.WriteLine(meinFahrzeug.ToString());
            }

            Console.ReadLine();
        }
    }
}