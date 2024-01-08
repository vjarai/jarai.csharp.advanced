namespace Jarai.CSharp.Interface5.DefaultImplementation;

internal class Program
{
    private static void Main(string[] args)
    {
        var example = new ExampleClass();

        example.MethodWithoutDefaultImplementation();

        example.MethodWithDefaultImplemantation();

        Console.ReadLine();
    }
}