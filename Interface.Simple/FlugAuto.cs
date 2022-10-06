namespace Jarai.CSharp.Interface.Simple
{
    /// <summary>
    /// In C# gibt es (zum Glück) keine Mehrfachvererbung,
    /// aber es können mehrere Interfaces implementiert werden
    /// </summary>
    public class FlugAuto : IFliegbar, IFahrbar
    {
        private readonly Flugzeug _flugzeug = new Flugzeug();
        private readonly Auto _auto = new Auto();


        public void Fahren()
        {
            // Workaraound: Statt Vererbung wird (intern) Aggregation benutzt
            _auto.Fahren(); // FlugAuto BENUTZT Auto zum fahren => Delegieren
        }

        public void Fliegen()
        {
            // Workaraound: Statt Vererbung wird (intern) Aggregation benutzt...
            _flugzeug.Fliegen();
        }
    }
}