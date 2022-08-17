using System;

namespace Jarai.Refresher.Relations
{
    public class Lkw : Kfz
    {
        private string _ladung;

        public Lkw(string marke) : base(marke)
        {
            Entladen();
        }

        public override void Anzeigen()
        {
            Console.WriteLine("Bin ein LKW!");
            Console.WriteLine("Habe '{0}' geladen!", _ladung);

            base.Anzeigen();
        }

        public void Beladen()
        {
            _ladung = "Steine";
        }

        public void Entladen()
        {
            _ladung = "nix";
        }

        public override void Fahren()
        {
            Console.WriteLine("Ladung wird gesichert.");
            base.Fahren();
        }
    }
}