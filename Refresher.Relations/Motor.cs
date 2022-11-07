namespace Jarai.CSharp.Advanced.Refresher.Relations
{
    public class Motor
    {
        public Motor(int leistung)
        {
            Leistung = leistung;
        }

        public bool IstAngelassen { get; private set; }

        public int Leistung { get; }

        public virtual void Start()
        {
            if (IstAngelassen) throw new InvalidOperationException("Motor is already running.");
            Console.WriteLine("Motor started.");
            IstAngelassen = true;
        }

        public virtual void Stop()
        {
            if (!IstAngelassen) throw new InvalidOperationException("Motor is not running.");
            Console.WriteLine("Motor stopped.");

            IstAngelassen = false;
        }

        public override string ToString()
        {
            return string.Format($"Motorleistung: {Leistung}\nMotor ist {(IstAngelassen ? "an" : "aus")}");
        }
    }
}