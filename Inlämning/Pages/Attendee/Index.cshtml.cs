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
    public class IndexModel : PageModel
    {
        private readonly Inlämning.Data.InlämningContext _context;

        public IndexModel(Inlämning.Data.InlämningContext context)
        {
            _context = context;
        }

        public IList<Attendee> Attendee { get;set; }

        public async Task OnGetAsync()
        {
            Attendee = await _context.Attendees.ToListAsync();
        }
    }
}
