using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Inlämning.Data;
using Inlämning.Models;

namespace Inlämning.Pages
{
    public class EventJoinModel : PageModel
    {
        private readonly Inlämning.Data.InlämningContext _context;

        public EventJoinModel(Inlämning.Data.InlämningContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }

        [BindProperty]
        public Event AddEvent { get; set; }
        public async Task<IActionResult> OnPostAsync(int? id)
        {

            var attendee = await _context.Attendees.Where(a => a.AttendeeID == 1).Include(e => e.Events).FirstOrDefaultAsync();

            var Joinedevent = await _context.Events.Where(e => e.EventID == id).FirstOrDefaultAsync();

            Joinedevent.SpotsAvailable--;

            attendee.Events.Add(Joinedevent);
            await _context.SaveChangesAsync();
            return RedirectToPage("/MyEvents", $"You have joined this event. {Joinedevent.Title} see you there!");

        }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Events
                .Include(o => o.Organizer).FirstOrDefaultAsync(m => m.EventID == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
