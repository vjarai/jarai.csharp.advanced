
namespace Optional.Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var adresse = new Adresse { Name = "Duck", Email = "Entenhausen", Plz = "8687686876876"};

            var validationService = new ValidationService();

            var validationResult = validationService.Validate(adresse);

            if (validationResult.HasErrors())
                Console.WriteLine(validationResult);
            else
                Console.WriteLine("Alles ok, Datensatz wird gespeichert.");

        }
    }
}