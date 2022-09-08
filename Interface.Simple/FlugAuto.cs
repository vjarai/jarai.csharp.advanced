namespace Jarai.CSharp.Interface.Simple
{
    public class FlugAuto : IFliegbar, IFahrbar
    {
        private Flugzeug _flugzeug = new Flugzeug();
        private Auto auto = new Auto();


        public void Fahren()
        {
            auto.Fahren(); // FlugAuto BENUTZT (internes) Auto zum fahren => Delegieren
        }

        public void Fliegen()
        {
            _flugzeug.Fliegen();
        }
    }
}