namespace Jarai.CSharp.Advanced.Refresher.Relations;

public class Car
{
    private readonly Engine _engine;

    public Car(string brand, Engine engine)
    {
        Brand = brand;
        _engine = engine;
    }

    public string Brand { get; }
    public double Odometer { get; private set; }
    public double FuelLevel { get; set; } = 20;

    public override string ToString()
    {
        return $"Brand: {Brand}\nOdometer: {Odometer}\n" + _engine;
    }

    public virtual void Drive(double distance)
    {
        _engine.Start();
        Odometer += distance;
        FuelLevel -= distance / 10;
        _engine.Stop();

        if (FuelLevel <= 0)
            throw new FuelEmptyException("Fuel tank is empty, please call roadside assistance.");

        Console.WriteLine("Destination reached.");
    }

    public void Refuel(double liters)
    {
        FuelLevel += liters;
    }
}