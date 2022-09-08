using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Ef6.DatabaseFirst
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Seminar> Seminars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasMany(e => e.Seminars)
                .WithMany(e => e.People)
                .Map(m => m.ToTable("SeminarPersons"));
        }
    }
}
