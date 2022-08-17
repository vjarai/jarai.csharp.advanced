using System.IO;
using Newtonsoft.Json;

namespace Jarai.Serialization
{
    internal class JsonFileRepository : FileRepository
    {
        public override T Load<T>(string filename = null)
        {
            filename = filename ?? GetDefaultFileName<T>(".json");

            var serializer = new JsonSerializer();

            using (var streamWRiter = new StreamReader(filename))
            using (var jsonWriter = new JsonTextReader(streamWRiter))
            {
                return serializer.Deserialize<T>(jsonWriter);
            }
        }

        public override void Save<T>(T objectToSave, string filename = null)
        {
            filename = filename ?? GetDefaultFileName<T>(".json");

            var serializer = new JsonSerializer();

            using (var streamWRiter = new StreamWriter(filename))
            using (var jsonWriter = new JsonTextWriter(streamWRiter))
            {
                serializer.Serialize(jsonWriter, objectToSave);
            }
        }
    }
}