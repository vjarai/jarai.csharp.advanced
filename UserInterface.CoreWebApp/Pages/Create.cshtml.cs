using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserInterface.CoreWebApp.Model;

namespace UserInterface.CoreWebApp.Pages
{
    public class CreateModel : PageModel
    {
        private readonly UserInterface.CoreWebApp.Data.SeminarContext _context;

        public CreateModel(UserInterface.CoreWebApp.Data.SeminarContext context)
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
