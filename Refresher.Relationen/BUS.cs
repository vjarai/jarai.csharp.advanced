using System;

namespace Jarai.Refresher.Relations
{
    public class Bus : Kfz
    {
        private string _passagiere;

        public Bus(string marke) : base(marke)
        {
            Aussteigen();
        }

        public override void Anzeigen()
        {
            Console.WriteLine("Bin ein BUS!");
            Console.WriteLine("Habe '{0}' geladen!", _passagiere);

            base.Anzeigen();
        }

        public void Aussteigen()
        {
            _passagiere = "nix";
        }

        public void Einsteigen()
        {
            _passagiere = "gesamte Dendrit Belegschaft";
        }

        public override void Fahren()
        {
            Console.WriteLine("Bitte festhalten!");
            base.Fahren();
        }
    }
}