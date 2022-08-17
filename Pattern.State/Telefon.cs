using System;
using System.Diagnostics;

namespace Jarai.Patterns.State
{
    public class Telefon
    {
        // Ein Telefon hat einen zustand
        // Beispiel f�r "Zustand Entwurfsmuster"

        public Telefon()
        {
            AktuellerZustand = new Aufgelegt();
        }

        public Zustand AktuellerZustand { get; private set; }

        public void Abheben()
        {
            Debug.WriteLine("\nAktueller Zustand: " + AktuellerZustand);
            // Die tats�chliche aktion ist abh�ngig vom aktuellen Zustand
            // (sp�tes binden)
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

        public void W�hlen()
        {
            Debug.WriteLine("\nAktueller Zustand: " + AktuellerZustand);
            AktualisiereZustand(AktuellerZustand.W�hlen());
        }

        public event EventHandler OnZustandGe�ndert;

        private bool AktualisiereZustand(Zustand neuerZustand)
        {
            var istGe�ndert = false;

            if (AktuellerZustand != neuerZustand)
            {
                istGe�ndert = true;
                AktuellerZustand = neuerZustand;
                if (OnZustandGe�ndert != null) OnZustandGe�ndert(this, null);
            }

            return istGe�ndert;
        }
    }
}