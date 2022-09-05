namespace Jarai.CSharp.Generic.ReturnType
{
    internal class Factory
    {
        /// <summary>
        /// Methode mit generischem Return Type und new Restriction
        /// </summary>
        /// <typeparam name="T">Der Typ des erstellenden Objects</typeparam>
        /// <returns>Ein Objekt vom Typ T</returns>
        public T Create<T>() where T : new()
        {
            T result = new T(); // benötigt new() Restriction
            return result;
        }
    }
}
