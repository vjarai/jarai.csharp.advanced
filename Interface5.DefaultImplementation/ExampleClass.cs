namespace Jarai.CSharp.Interface5.DefaultImplementation;

internal class ExampleClass : IExampleInterface
{
    public void MethodWithoutDefaultImplementation()
    {
        Console.WriteLine("Implementation of MethodWithDefaultImplemantation");
    }

    /// <summary>
    /// Die Default Methoden Implementierung kann ggf. in der Klasse überschrieben werden.
    /// </summary>
    public void MethodWithDefaultImplemantation()
    {
        Console.WriteLine("Overwritten implementation of MethodWithDefaultImplemantation");
    }
}