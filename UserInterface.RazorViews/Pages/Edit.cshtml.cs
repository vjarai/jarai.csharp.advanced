using Jarai.CSharp.UserInterface.CoreWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Jarai.CSharp.UserInterface.CoreWebApp.Pages
{
    public class EditModel : PageModel
    {
        private readonly global::Jarai.CSharp.UserInterface.CoreWebApp.Data.SeminarContext _context;

        public EditModel(global::Jarai.CSharp.UserInterface.CoreWebApp.Data.SeminarContext context)
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

            var seminar =  await _context.Seminar.FirstOrDefaultAsync(m => m.Id == id);
            if (seminar == null)
            {
                return NotFound();
            }
            Seminar = seminar;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Seminar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SeminarExists(Seminar.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SeminarExists(int id)
        {
          return (_context.Seminar?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
