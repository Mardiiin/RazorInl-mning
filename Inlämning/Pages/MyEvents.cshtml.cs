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
    public class MyEventsModel : PageModel
    {
        private readonly Inlämning.Data.InlämningContext _context;

        public MyEventsModel(Inlämning.Data.InlämningContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get; set; }
        public Attendee Attendee { get; set; }
        public string Message { get; set; }

        public async Task<IActionResult> OnPostAsync(int? id)
        {

            var attendee = await _context.Attendees.Where(a => a.AttendeeID == 1).Include(e => e.Events).FirstOrDefaultAsync();

            var leaveEvent = await _context.Events.Where(e => e.EventID == id).FirstOrDefaultAsync();

            leaveEvent.SpotsAvailable++;

            attendee.Events.Remove(leaveEvent);
            await _context.SaveChangesAsync();
            return RedirectToPage($"/MyEvents", $"You have left the event: {leaveEvent.Title}");

        }
        public void OnGetAsync(string handler = "")
        {
            Attendee = _context.Attendees.Where(a => a.AttendeeID == 1).Include(e => e.Events).FirstOrDefault();

            Message = handler;

            Event = Attendee.Events;


        }
    }
}
