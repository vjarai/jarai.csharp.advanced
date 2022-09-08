using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UserInterface.CoreWebApp.Model;

namespace UserInterface.CoreWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly UserInterface.CoreWebApp.Data.SeminarContext _context;

        public IndexModel(UserInterface.CoreWebApp.Data.SeminarContext context)
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
