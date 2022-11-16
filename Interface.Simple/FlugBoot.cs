namespace Jarai.CSharp.Interface.Simple
{
    /// <summary>
    /// In C# gibt es (zum Glück) keine Mehrfachvererbung,
    /// aber es können mehrere Interfaces implementiert werden
    /// </summary>
    public class FlugBoot : IFlugzeug, ISchiff
    {
        private readonly Flugzeug _internesFlugzeug = new Flugzeug();
        private readonly Schiff _internesSchiff = new Schiff();


        public void Schwimmen()
        {
            // Workaraound: Statt Vererbung wird (intern) Aggregation benutzt
            _internesSchiff.Schwimmen(); // FlugBoot BENUTZT Schiff zum fahren => Delegieren
        }

        public void Fliegen()
        {
            // Workaraound: Statt Vererbung wird (intern) Aggregation benutzt...
            _internesFlugzeug.Fliegen();
        }
    }
}