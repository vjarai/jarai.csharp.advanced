using Jarai.CSharp.UserInterface.CoreWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Jarai.CSharp.UserInterface.CoreWebApp.Pages
{
    public class CreateModel : PageModel
    {
        private readonly global::Jarai.CSharp.UserInterface.CoreWebApp.Data.SeminarContext _context;

        public CreateModel(global::Jarai.CSharp.UserInterface.CoreWebApp.Data.SeminarContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Seminar Seminar { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Seminar == null || Seminar == null)
            {
                return Page();
            }

            _context.Seminar.Add(Seminar);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
