namespace Jarai.CSharp.EntityFrameworkCore.CodeFirst
{
    public class Contact
    {
        public Contact()
        {
            Created = DateTime.Now;
            Name = string.Empty;
        }

        public DateTime Created { get; set; }

        public int Id { get; set; }

        public DateTime? Modified { get; set; }

        public string Name { get; set; }
    }
}
