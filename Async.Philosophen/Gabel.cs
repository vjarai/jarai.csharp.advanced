namespace Jarai.CSharp.Async.Lock;

internal class Gabel
{
    public Gabel(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public Philosoph User { get; set; }

    public void Grab(Philosoph philosoph)
    {
        User = philosoph;
        Console.WriteLine($"{philosoph.Name} nimmt {Name}.");
    }

    public void Put()
    {
        Console.WriteLine($"{User.Name} legt {Name}.");
        User = null;
    }
}