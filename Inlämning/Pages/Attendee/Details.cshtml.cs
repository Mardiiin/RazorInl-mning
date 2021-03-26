using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Inlämning.Data;
using Inlämning.Models;

namespace Inlämning.Pages.Attendee
{
    public class DetailsModel : PageModel
    {
        private readonly Inlämning.Data.InlämningContext _context;

        public DetailsModel(Inlämning.Data.InlämningContext context)
        {
            _context = context;
        }

        public Attendee Attendee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Attendee = await _context.Attendees.FirstOrDefaultAsync(m => m.AttendeeID == id);

            if (Attendee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
