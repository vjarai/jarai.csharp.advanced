namespace Jarai.CSharp.Interface.Simple
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var auto = new Schiff();
            var flugzeug = new Flugzeug();
            var flugAuto = new FlugBoot();

            var person = new Person();

            person.Verreisen(auto);
            person.Fliegen(flugzeug);

            person.Verreisen(flugAuto);
            person.Fliegen(flugAuto);
        }
    }
}