using System;

namespace Jarai.Generic.LazyLoad
{
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