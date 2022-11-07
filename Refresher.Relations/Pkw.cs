namespace Jarai.CSharp.Advanced.Refresher.Relations
{
    public class Pkw : Kfz
    {

        public Pkw(string marke, Motor motor) : base(marke, motor)
        {
        }

        public double Tankinhalt { get; set; } = 20;

        public override string ToString()
        {
            return "Pkw Daten:" + base.ToString();
        }

        public void Tanken(double liter)
        {
            Tankinhalt += liter;
        }
       
        public override void Fahren(double strecke)
        {
            Console.WriteLine("Wir fahren mit dem Pkw.");
            base.Fahren(strecke);
            Tankinhalt -= strecke / 10;

            if (Tankinhalt <= 0)
                throw new TankleerException("Tank ist Leer, ADAC rufen.");
        }
    }
}