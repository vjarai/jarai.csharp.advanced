namespace Jarai.CSharp.Advanced.Refresher.Relations;

public class Engine
{
    public Engine(int power)
    {
        Power = power;
    }

    public bool IsRunning { get; private set; }

    public int Power { get; }

    public virtual void Start()
    {
        if (IsRunning) throw new InvalidOperationException("Engine is already running.");
        Console.WriteLine("Engine started.");
        IsRunning = true;
    }

    public virtual void Stop()
    {
        if (!IsRunning) throw new InvalidOperationException("Engine is not running.");
        Console.WriteLine("Engine stopped.");

        IsRunning = false;
    }

    public override string ToString()
    {
        return $"Engine power: {Power}\nEngine is {(IsRunning ? "on" : "off")}";
    }
}