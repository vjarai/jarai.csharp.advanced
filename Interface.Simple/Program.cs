namespace Jarai.CSharp.Interface.Simple;

internal class Program
{
    private static void Main(string[] args)
    {
        var wand = new Wand();
        var ski = new Ski();
        var auto = new Auto();

        var maler = new Maler();

        maler.Lackieren(wand);
        maler.Fahren(ski);

        maler.Lackieren(auto);
        maler.Fahren(auto);
    }
}