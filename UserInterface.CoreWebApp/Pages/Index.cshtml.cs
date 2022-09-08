using Jarai.CSharp.UserInterface.CoreWebApp.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Jarai.CSharp.UserInterface.CoreWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly global::Jarai.CSharp.UserInterface.CoreWebApp.Data.SeminarContext _context;

        public IndexModel(global::Jarai.CSharp.UserInterface.CoreWebApp.Data.SeminarContext context)
        {
            _context = context;
        }

        public IList<Seminar> Seminar { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Seminar != null)
            {
                Seminar = await _context.Seminar.ToListAsync();
            }
        }
    }
}
