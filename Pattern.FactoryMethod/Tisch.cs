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

            Console.WriteLine("Ich stelle den Teller auf den Tisch.");
        }

        public override void Montieren()
        {
            Console.WriteLine("Die Tischplatte wird festgeschraubt.");
            IstMontiert = true;
        }
    }
}