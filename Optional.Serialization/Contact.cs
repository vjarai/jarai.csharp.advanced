namespace Jarai.CSharp.Serialization
{
    public class Contact
    {
        private Contact()
        {
        }

        public string Name { get; set; }

        public int Plz { get; set; }

        public static Contact Create(string name, int plz)
        {
            return new Contact
            {
                Name = name,
                Plz = plz
            };
        }
    }
}