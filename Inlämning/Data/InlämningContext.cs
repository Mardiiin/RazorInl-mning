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
        public DbSet<Organizer> Organizers { get; set; }


        public void Seeding()
        {
            this.Database.EnsureCreated();

            if (Events.Any() ||
               Attendees.Any() ||
                Organizers.Any())
            {
                return;
            }


            Attendees.AddRange(new List<Attendee>()
            {
                new Attendee() { Name = "Cliff Booth", Emailaddress = "mansonfamily@hotmai.com", PhoneNumber= "6160066123"},

               new Attendee() { Name = "Rick Dalton", Emailaddress = "hasbeen@hotmail.com", PhoneNumber= "5091558129"},

                new Attendee() { Name = "Lundgrens Skåne", Emailaddress = "sheeeshwhatup@hotmail.com", PhoneNumber= "4141421248"}
            });
            SaveChanges();

            Organizers.AddRange(new List<Organizer>()
            {
               new Organizer() { Name = "SeinfeldCast", EmailAddress = "bigmoney@hotmail.com", PhoneNumber= "512549129"},
                new Organizer() { Name = "ThomasShelby", EmailAddress = "2ndbigmoney@hotmail.com", PhoneNumber= "915215591"}

            });
            SaveChanges();

            Events.AddRange(new List<Event>()
            {
                new Event() { Title = "Beast", Description= "GoodTime", Organizer = Organizers.Where(o => o.Name=="SeinfeldCast").FirstOrDefault(), Place= "North Yankton", Address= "Pinkerton Road 12", Date=DateTime.Parse ("2021-03-14 16:00"), SpotsAvailable= 120 },
                new Event() { Title = "Clifferton", Description= "Blinders", Organizer = Organizers.Where(o => o.Name=="ThomasShelby").FirstOrDefault(), Place= "Small Heath", Address= "Jefferson Street 54", Date=DateTime.Parse ("2021-06-12 12:00"), SpotsAvailable= 88 },
                new Event() { Title = "SetmeUp", Description= "ShowdownInHell", Organizer = Organizers.Where(o => o.Name=="ThomasShelby").FirstOrDefault(), Place= "Hell", Address= "Sheeesh street 12", Date=DateTime.Parse ("2021-04-15 10:00"), SpotsAvailable= 76 },
                new Event() { Title = "YEEHAW", Description= "Guns", Organizer = Organizers.Where(o => o.Name=="SeinfeldCast").FirstOrDefault(), Place= "Göteborg", Address= "Chiperton Dinkle 12", Date=DateTime.Parse ("2021-09-12 18:00"), SpotsAvailable= 25 }


            });
            SaveChanges();







        }
    }
}
