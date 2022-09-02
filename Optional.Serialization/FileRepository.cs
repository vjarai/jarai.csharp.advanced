namespace Jarai.CSharp.Serialization
{
    internal abstract class FileRepository
    {
        public T Clone<T>(T objectToClone)
        {
            Save(objectToClone);
            return Load<T>();
        }

        public abstract T Load<T>(string filename = null);
        public abstract void Save<T>(T objectToSave, string filename = null);

        protected string GetDefaultFileName<T>(string fileExtension)
        {
            return @"C:\temp\" + typeof(T).Name + fileExtension;
        }
    }
}