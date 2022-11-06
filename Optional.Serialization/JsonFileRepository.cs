using Newtonsoft.Json;

namespace Jarai.CSharp.Optional.Serialization
{
    /// <summary>
    /// Persistiert Objekte beliebigen Typs in einer Json Datei
    /// </summary>
    internal class JsonFileRepository : FileRepository
    {
        public override T Load<T>(string filename = null)
        {
            filename = filename ?? GetDefaultFileName<T>(".json");

            var serializer = new JsonSerializer();

            using (var streamReader = new StreamReader(filename))
            using (var jsonWriter = new JsonTextReader(streamReader))
            {
                return serializer.Deserialize<T>(jsonWriter);
            }
        }

        public override void Save<T>(T objectToSave, string filename = null)
        {
            filename = filename ?? GetDefaultFileName<T>(".json");

            var serializer = new JsonSerializer();

            using (var streamWriter = new StreamWriter(filename))
            using (var jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, objectToSave);
            }
        }
    }
}