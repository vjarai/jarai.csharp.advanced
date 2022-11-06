namespace Jarai.CSharp.Advanced.Refresher.Relations
{
    public abstract class Kfz
    {
        public string Marke { get; }

        private readonly Motor _motor;
        public double TachoStand { get; private set; }

        protected Kfz(string marke, Motor motor)
        {
            Marke = marke;
            _motor = motor;
        }

        public override string ToString()
        {
            return string.Format( $"Marke: {Marke}\nTachostand: {TachoStand}\n"  + _motor);
        }

        public virtual void Fahren(double strecke)
        {
            _motor.Start();
            TachoStand += strecke;
            Console.WriteLine("Ziel erreicht.");
            _motor.Stop();

        }
    }
}