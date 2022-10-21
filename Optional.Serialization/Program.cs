namespace Jarai.CSharp.Serialization
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var repository = new XmlFileRepository();
            //var repository = new JsonFileRepository();

            var newContact = new Contact { Name = "Meier", Plz = 12345 };

            repository.Save(newContact);

            var loadedContact = repository.Load<Contact>();

            var clonedContact = repository.Clone(newContact);
        }
    }
}