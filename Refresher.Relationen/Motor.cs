using System;

namespace Jarai.Refresher.Relations
{
    public class Motor
    {
        public Motor(int leistung)
        {
            Leistung = leistung;
        }

        public bool IstAngelassen { get; private set; }

        public int Leistung { get; }

        public void Anlassen()
        {
            if (IstAngelassen) throw new InvalidOperationException();

            IstAngelassen = true;
        }

        public void Anzeigen()
        {
            Console.WriteLine("- Motorleistung: {0}", Leistung);

            Console.WriteLine("- Motor {0}", IstAngelassen ? "läuft" : "aus");
        }
    }
}