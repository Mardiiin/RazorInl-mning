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
    public class EventsModel : PageModel
    {
        private readonly Inlämning.Data.InlämningContext _context;

        public EventsModel(Inlämning.Data.InlämningContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get;set; }

        public async Task OnGetAsync()
        {
            Event = await _context.Events
                .Include(o => o.Organizer).ToListAsync();
        }
    }
}
