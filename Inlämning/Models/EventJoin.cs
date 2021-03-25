using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämning.Models
{
    public class EventJoin
    {
        public int AttendeeID { get; set; }
        public int EventID { get; set; }
        public int EventJoinID { get; set; }
        public Attendee Attendee { get; set; }
        public Event Event { get; set; }
    }
}
