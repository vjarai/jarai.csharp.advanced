namespace Jarai.CSharp.Generic.ReturnType
{
    internal class Factory
    {
        public T Create<T>() where T : new()
        {
            T result = new T();
            return result;
        }
    }
}
