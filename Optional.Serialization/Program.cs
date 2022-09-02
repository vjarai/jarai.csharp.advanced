namespace Jarai.CSharp.Serialization
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var repository = new XmlFileRepository();
            var repository = new JsonFileRepository();

            var newContact = Contact.Create("Meier", 12345);

            repository.Save(newContact);

            var loadedContact = repository.Load<Contact>();

            var clonedContact = repository.Clone(newContact);
        }
    }
}