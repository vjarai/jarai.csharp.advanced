using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UserInterface.CoreWebApp.Model;

namespace UserInterface.CoreWebApp.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly UserInterface.CoreWebApp.Data.SeminarContext _context;

        public DetailsModel(UserInterface.CoreWebApp.Data.SeminarContext context)
        {
            _context = context;
        }

      public Seminar Seminar { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Seminar == null)
            {
                return NotFound();
            }

            var seminar = await _context.Seminar.FirstOrDefaultAsync(m => m.Id == id);
            if (seminar == null)
            {
                return NotFound();
            }
            else 
            {
                Seminar = seminar;
            }
            return Page();
        }
    }
}
