using System.Diagnostics;

namespace Jarai.Patterns.FactoryMethod
{
    public class Stuhl : Möbel
    {
        public Stuhl() : base("Stuhl Sven", 25)
        {
        }

        public Stuhl(string name, double preis)
            : base(name, preis)
        {
        }

        public override void Benutzen()
        {
            ThrowExceptionIfNotAssembled();

            Debug.WriteLine("Ich setze mich auf den Stuhl.");
        }

        public override void Montieren()
        {
            Debug.WriteLine("Die Beine werden an den Stuhl geschraubt.");
            IsAssembled = true;
        }
    }
}