using System.Data.Entity;

namespace EF6.CodeFirst
{
    internal class Datenbank : DbContext
    {
        public DbSet<Person> Personen { get; set; }
        public DbSet<Seminar> Seminare { get; set; }

    }


    
}