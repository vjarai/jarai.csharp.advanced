using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Jarai.CSharp.Ef6.DatabaseFirst
{
    public partial class Database : DbContext
    {
        public Database()
            : base("name=Database")
        {
        }

        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Seminar> Seminar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasMany(e => e.Seminar)
                .WithMany(e => e.Person)
                .Map(m => m.ToTable("SeminarPerson"));
        }
    }
}
