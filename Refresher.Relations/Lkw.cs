namespace Jarai.CSharp.Advanced.Refresher.Relations
{
    public class Lkw : Kfz
    {
        public string Ladung { get; private set; } = "";

        public Lkw(string marke) : base(marke, new Motor(300))
        {
        }

        public override string ToString()
        {
            return string.Format($"Lkw, beladen mit '{Ladung}'.\n") + base.ToString();
        }

        public void Enladen()
        {
            Ladung = "";
        }

        public void Beladen()
        {
            Ladung = "Backsteine";
        }

        public override void Fahren(double strecke)
        {
            Console.WriteLine("Ladung wird gesichert.");
            base.Fahren(strecke);
        }
    }
}