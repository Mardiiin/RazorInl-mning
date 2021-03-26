using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inlämning.Models;

namespace Inlämning.Data
{
    public class InlämningContext : DbContext
    {

        public InlämningContext(DbContextOptions<InlämningContext> options)
            : base(options)
        {
        }

        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventJoin> JoinedEvents { get; set; }
        public DbSet<Organizer> Organizers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendee>().ToTable("Attendee");
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<EventJoin>().ToTable("EventJoined");
            modelBuilder.Entity<Organizer>().ToTable("Organizer");
        }


        
        




    }
}
