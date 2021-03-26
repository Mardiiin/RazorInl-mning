using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Inlämning.Data;
using Inlämning.Models;

namespace Inlämning.Pages.Attendee
{
    public class CreateModel : PageModel
    {
        private readonly Inlämning.Data.InlämningContext _context;

        public CreateModel(Inlämning.Data.InlämningContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Attendee Attendee { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attendees.Add(Attendee);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
