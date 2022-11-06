using System.Diagnostics;

namespace Jarai.CSharp.Pattern.FactoryMethod
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

            Console.WriteLine("Ich setze mich auf den Stuhl.");
        }

        public override void Montieren()
        {
            Console.WriteLine("Die Beine werden an den Stuhl geschraubt.");
            IsAssembled = true;
        }
    }
}