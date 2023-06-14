namespace Jarai.CSharp.Interface.Simple;

/// <summary>
///     In C# gibt es (zum Glück) keine Mehrfachvererbung,
///     aber es können mehrere Interfaces implementiert werden
/// </summary>
public class Auto : IFahrbar, ILackierbar
{
    public void Fahren()
    {
        Console.WriteLine("... mit Auto");
    }

    public string Farbe { get; set; }
}