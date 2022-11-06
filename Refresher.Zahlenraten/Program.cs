namespace Jarai.CSharp.Advanced.Refresher.Zahlenraten
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string eingabe;

            do
            {
                // Variablen definieren
                int tipp, anzahlVersuche = 0;

                // Berechnung Zufallszahl
                var r = new Random();
                int geheimzahl = r.Next(1, 101);

                // Ausgabe (nur zum debuggen)
                Console.WriteLine("Geheimzahl:" + geheimzahl);

                // Einlesen von Tastatureingaben
                Console.WriteLine("Willkommen zum frˆhlichen Zahlenraten (zwischen 1 und 100)!");

                do
                {
                    Console.WriteLine("Bitte Tipp eingeben: ");
                    eingabe = Console.ReadLine();

                    tipp = int.Parse(eingabe);

                    anzahlVersuche++;

                    if (tipp > geheimzahl)
                    {
                        Console.WriteLine("Leider zu groﬂ...");
                    }
                    else if (tipp < geheimzahl)
                    {
                        Console.WriteLine("Leider zu klein...");
                    }

                } while (tipp != geheimzahl);

                Console.WriteLine("Gewonnen !\nUnd das mit nur " + anzahlVersuche + " Versuchen!!!");

                Console.WriteLine("Noch einmal? (J/N)");
                eingabe = Console.ReadLine();

            } while (eingabe == "J" || eingabe == "j");
        }
    }
}
