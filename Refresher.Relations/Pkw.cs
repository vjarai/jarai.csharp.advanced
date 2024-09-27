namespace Jarai.CSharp.Advanced.Refresher.Relations
{
    public class Pkw
    {
        public string Marke { get; }

        private readonly Motor _motor;
        public double TachoStand { get; private set; }
        public double Tankinhalt { get; set; } = 20;

        public Pkw(string marke, Motor motor)
        {
            Marke = marke;
            _motor = motor;
        }

        public override string ToString()
        {
            return  $"Marke: {Marke}\nTachostand: {TachoStand}\n"  + _motor;
        }

        public virtual void Fahren(double strecke)
        {
            _motor.Start();
            TachoStand += strecke;
            Tankinhalt -= strecke / 10;
            _motor.Stop();

            if (Tankinhalt <= 0)
                throw new TankleerException("Tank ist Leer, ADAC rufen.");

            Console.WriteLine("Ziel erreicht.");
        }

        public void Tanken(double liter)
        {
            Tankinhalt += liter;
        }
    }
}