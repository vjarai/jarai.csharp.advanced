namespace Jarai.CSharp.Advanced.Refresher.Relations
{
    public class Cabrio : Pkw
    {

        public Cabrio(string marke, Motor motor) : base(marke, motor)
        {
        }

        public override string ToString()
        {
            return "Cabrio Daten:" + base.ToString();
        }

        public override void Fahren(double strecke)
        {
            Console.WriteLine("Wir fahren mit dem Cabrio.");
            VerdeckÖffnen();

            base.Fahren(strecke);

            VerdeckSchliessen();
        }

        public void VerdeckÖffnen()
        {
            Console.WriteLine("Verdeck wird geöffnet.");
        }

        public void VerdeckSchliessen()
        {
            Console.WriteLine("Verdeck wird geschlossen.");
        }
    }
}