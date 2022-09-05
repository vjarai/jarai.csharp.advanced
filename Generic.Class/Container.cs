namespace Jarai.CSharp.Generic.Class
{
    /// <summary>
    /// Generische Containerklasse mit Nutzdaten (Value) vom Typ T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Container<T /* ,U */>
        /* where T: new(), Class, Interface */
        /* where U: new(), Class, Interface */
    {
        private T _value; // = new T();

        /// <summary>
        ///     Liefert true, wenn _value gesetzt wurde
        /// </summary>
        public bool HasValue { get; private set; }

        public T GetValue()
        {
            return _value;
        }

        public void SetValue(T wert)
        {
            _value = wert;
            HasValue = wert != null;
        }
    }
}