using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserInterface.CoreWebApp.Model;

namespace UserInterface.CoreWebApp.Data
{
    public class SeminarContext : DbContext
    {
        public SeminarContext (DbContextOptions<SeminarContext> options)
            : base(options)
        {
        }

        public DbSet<UserInterface.CoreWebApp.Model.Seminar> Seminar { get; set; } = default!;
    }
}
