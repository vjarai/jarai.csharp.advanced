namespace Jarai.CSharp.Interface.Simple
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var auto = new Auto();
            var flugzeug = new Flugzeug();
            var flugAuto = new FlugAuto();

            var person = new Person();

            person.Fahren(auto);
            person.Fliegen(flugzeug);

            person.Fahren(flugAuto);
            person.Fliegen(flugAuto);
        }
    }
}