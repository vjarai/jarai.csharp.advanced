using Microsoft.EntityFrameworkCore;

namespace Jarai.CSharp.UserInterface.CoreWebApp.Data
{
    public class SeminarContext : DbContext
    {
        public SeminarContext (DbContextOptions<SeminarContext> options)
            : base(options)
        {
        }

        public DbSet<Seminar> Seminar { get; set; } = default!;
    }
}
