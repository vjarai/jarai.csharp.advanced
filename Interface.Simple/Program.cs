namespace Jarai.CSharp.Interface.Simple;

internal class Program
{
    private static void Main(string[] args)
    {
        var auto = new Wand();
        var flugzeug = new Ski();
        var flugAuto = new Auto();

        var person = new Maler();

        person.Lackieren(auto);
        person.Fahren(flugzeug);

        person.Lackieren(flugAuto);
        person.Fahren(flugAuto);
    }
}