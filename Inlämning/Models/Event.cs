using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämning.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string Title { get; set; }
        public int OrganizerID { get; set; }
        public string Description { get; set; }
        public Organizer Organizer { get; set; }
        public string Address { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public int SpotsAvailable { get; set; }
        public List<Attendee> Attendee { get; set; }

    }
}
