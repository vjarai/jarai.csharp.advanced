namespace Jarai.CSharp.Interface.Simple
{
    /// <summary>
    /// In C# gibt es (zum Glück) keine Mehrfachvererbung,
    /// aber es können mehrere Interfaces implementiert werden
    /// </summary>
    public class FlugAuto : IFliegbar, IFahrbar
    {
        private readonly Flugzeug _internesFlugzeug = new Flugzeug();
        private readonly Auto _internesAuto = new Auto();


        public void Fahren()
        {
            // Workaraound: Statt Vererbung wird (intern) Aggregation benutzt
            _internesAuto.Fahren(); // FlugAuto BENUTZT Auto zum fahren => Delegieren
        }

        public void Fliegen()
        {
            // Workaraound: Statt Vererbung wird (intern) Aggregation benutzt...
            _internesFlugzeug.Fliegen();
        }
    }
}