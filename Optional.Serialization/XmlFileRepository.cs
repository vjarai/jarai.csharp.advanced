using System.IO;
using System.Xml.Serialization;

namespace Jarai.CSharp.Serialization
{
    /// <summary>
    /// Persistiert Objekte beliebigen Typs in einer Xml Datei
    /// </summary>
    internal class XmlFileRepository : FileRepository
    {
        public override T Load<T>(string filename = null)
        {
            filename = filename ?? GetDefaultFileName<T>(".xml");

            var xmlSerializer = new XmlSerializer(typeof(T));

            using (var stream = File.OpenRead(filename))
            {
                return (T)xmlSerializer.Deserialize(stream);
            }
        }

        public override void Save<T>(T objectToSave, string filename = null)
        {
            filename = filename ?? GetDefaultFileName<T>(".xml");

            var xmlSerializer = new XmlSerializer(typeof(T));

            using (var writer = new StreamWriter(filename))
            {
                xmlSerializer.Serialize(writer, objectToSave);
                writer.Close();
            }
        }
    }
}