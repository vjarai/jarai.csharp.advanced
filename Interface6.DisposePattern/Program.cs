namespace Interface6.DisposePattern
{
    internal class Program
    {
        // https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/implementing-dispose
        // https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/dispose-pattern
        static void Main(string[] args)
        {
            using var foo = new Foo();
            foo.DoSomething();
        }
    }
}
