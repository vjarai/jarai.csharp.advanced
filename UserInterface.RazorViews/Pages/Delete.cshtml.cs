using Jarai.CSharp.UserInterface.CoreWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Jarai.CSharp.UserInterface.CoreWebApp.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly global::Jarai.CSharp.UserInterface.CoreWebApp.Data.SeminarContext _context;

        public DeleteModel(global::Jarai.CSharp.UserInterface.CoreWebApp.Data.SeminarContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Seminar == null)
            {
                return NotFound();
            }
            var seminar = await _context.Seminar.FindAsync(id);

            if (seminar != null)
            {
                Seminar = seminar;
                _context.Seminar.Remove(Seminar);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
