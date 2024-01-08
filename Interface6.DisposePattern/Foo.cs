using System.Diagnostics;

namespace Interface6.DisposePattern;

/// <summary>
/// Class owning disposable resources should implement IDisposable themselves.
/// </summary>
public sealed class Foo : IDisposable
{
    private readonly Bar _bar;

    public Foo()
    {
        _bar = new Bar();
    }

    public void Dispose() => _bar.Dispose();

    public void DoSomething()
    {
        Console.WriteLine("Foo.DoSomething()");
    }
}


/// <summary>
/// Sample Class owning unmanaged resources.
/// </summary>
public class Bar : IDisposable
{
    private bool _disposed = false;

    public Bar()
    {
        // TODO acquiere unmanaged resources here
    }


    /// <summary>
    /// Dispose Methods should be virtual to allow derived classes to override them.
    /// Dispose Methods should be idempotent (can be called multiple times without throwing an exception).
    /// </summary>
    public virtual void Dispose()
    {
        Console.WriteLine("Bar.Dispose()");

        // This is the default Dispose implementation
        Dispose(true);
        GC.SuppressFinalize(this);

    }

    /// <summary>
    /// The disposing parameter is a Boolean that indicates whether the method call comes from a Dispose method (its value is true)
    /// or from a finalizer (its value is false).
    /// </summary>
    /// <param name="disposing">
    /// true, when called from parameterless Dispose Method, false when called from finalizer
    /// </param>
    protected virtual void Dispose(bool disposing)
    {
        Console.WriteLine("Bar.Dispose(bool dispopsing)");

        if (_disposed)  // ignore, if already disposed
        {
            return;
        }

        if (disposing) // called by parameterless Dispose Method?
        {
            // TODO: dispose managed state (managed objects).
        }

        // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
        // TODO: set large fields to null.

        _disposed = true;
    }
}