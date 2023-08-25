using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EvManagerDemo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
            
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {            
        }

        public virtual DbSet<Event> Events { get; set; }

        public virtual DbSet<EventDay> EventDays { get; set; }

        public virtual DbSet<TimeSlot> TimeSlots { get; set; }
    }
}