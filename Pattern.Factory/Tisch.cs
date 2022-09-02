using System.Diagnostics;

namespace Jarai.CSharp.Pattern.FactoryMethod
{
    public class Tisch : Möbel
    {
        public Tisch(string name, double preis)
            : base(name, preis)
        {
        }

        public Tisch()
            : this("Tisch Max", 100)
        {
        }

        public override void Benutzen()
        {
            ThrowExceptionIfNotAssembled();

            Debug.WriteLine("Ich stelle den Teller auf den Tisch.");
        }

        public override void Montieren()
        {
            Debug.WriteLine("Die Tischplatte wird festgeschraubt.");
            IsAssembled = true;
        }
    }
}