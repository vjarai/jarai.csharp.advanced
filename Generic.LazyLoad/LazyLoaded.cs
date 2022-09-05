using System;

namespace Jarai.CSharp.Generic.LazyLoad
{
    /// <summary>
    /// Lazyload Pattern:
    /// Lädt / erstellt ein Object nur bei bedarf (d.h. beim ersten Zugriff)
    /// Kann verwendet werden, um die Startzeit zu verringern.
    /// Ist im Prinzip ein simpler Caching Mechanismus.
    /// Vorsicht vor Cache inkonsistenzen!!!
    ///
    /// (In echten Anwendungen die .NET Klasse Lazy verwenden.)
    /// </summary>
    /// <typeparam name="T">Der Typ des zu cahenden Objekts</typeparam>
    internal class LazyLoaded<T>
    {
        private readonly Func<T> _loadingFunc;
        private T _value;

        public LazyLoaded(Func<T> loadingFunc)
        {
            _loadingFunc = loadingFunc;
        }

        public bool IsLoaded { get; private set; }

        public T Value
        {
            get
            {
                if (!IsLoaded)
                {
                    _value = _loadingFunc.Invoke();
                    IsLoaded = true;
                }

                return _value;
            }
            set { _value = value; }
        }
    }
}