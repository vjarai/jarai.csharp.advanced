using System;
using System.Diagnostics;

namespace Jarai.Patterns.State
{
    public class Telefon
    {
        // Ein Telefon hat einen zustand
        // Beispiel für "Zustand Entwurfsmuster"

        public Telefon()
        {
            AktuellerZustand = new Aufgelegt();
        }

        public Zustand AktuellerZustand { get; private set; }

        public void Abheben()
        {
            Debug.WriteLine("\nAktueller Zustand: " + AktuellerZustand);
            // Die tatsächliche aktion ist abhängig vom aktuellen Zustand
            // (spätes binden)
            AktualisiereZustand(AktuellerZustand.Abheben());
        }

        public void AnnehmenAnruf()
        {
            Debug.WriteLine("\nAktueller Zustand: " + AktuellerZustand);

            AktualisiereZustand(AktuellerZustand.AnnehmenAnruf());
        }


        public void Auflegen()
        {
            Debug.WriteLine("\nAktueller Zustand: " + AktuellerZustand);
            AktualisiereZustand(AktuellerZustand.Auflegen());
        }

        public void Sprechen()
        {
            Debug.WriteLine("\nAktueller Zustand: " + AktuellerZustand);
            AktuellerZustand = AktuellerZustand.Sprechen();
        }

        public void Wählen()
        {
            Debug.WriteLine("\nAktueller Zustand: " + AktuellerZustand);
            AktualisiereZustand(AktuellerZustand.Wählen());
        }

        public event EventHandler OnZustandGeändert;

        private bool AktualisiereZustand(Zustand neuerZustand)
        {
            var istGeändert = false;

            if (AktuellerZustand != neuerZustand)
            {
                istGeändert = true;
                AktuellerZustand = neuerZustand;
                if (OnZustandGeändert != null) OnZustandGeändert(this, null);
            }

            return istGeändert;
        }
    }
}