using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Jarai.CSharp.EF6.CodeFirst
{
    internal class Datenbank : DbContext
    {
        public DbSet<Person> Personen { get; set; }
        public DbSet<Seminar> Seminare { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }


    
}