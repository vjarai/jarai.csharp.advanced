namespace Jarai.CSharp.Interface.Simple;

internal class Maler
{
    public void Lackieren(ILackierbar lackierbar)
    {
        Console.WriteLine("Maler lackiert...");
        lackierbar.Farbe = "Blau";
    }

    public void Fahren(IFahrbar fahrbar)
    {
        Console.WriteLine("Maler fährt...");
        fahrbar.Fahren();
    }
}