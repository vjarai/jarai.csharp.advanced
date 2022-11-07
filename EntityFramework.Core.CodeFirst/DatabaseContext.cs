using Microsoft.EntityFrameworkCore;

namespace Jarai.CSharp.EntityFrameworkCore.CodeFirst
{
    internal class DatabaseContext : DbContext
    {
        private readonly string _connectionString =
            @"data source=(localdb)\MSSQLLocalDB;initial catalog=Jarai.CSharp.EntityFramework.Core.CodeFirst;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        
        public DbSet<Contact> Contacts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
