namespace Jarai.CSharp.Advanced.Refresher.Relations;

public class Cabriolet : Car
{
    public Cabriolet(string brand, Engine engine) : base(brand, engine)
    {
    }

    public override string ToString()
    {
        return "Cabriolet Data: " + base.ToString();
    }

    public override void Drive(double distance)
    {
        Console.WriteLine("Driving with the cabriolet.");
        OpenRoof();

        base.Drive(distance);

        CloseRoof();
    }

    public void OpenRoof()
    {
        Console.WriteLine("Roof is opening.");
    }

    public void CloseRoof()
    {
        Console.WriteLine("Roof is closing.");
    }
}