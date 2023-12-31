﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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

        public virtual DbSet<EventRegistration> EventRegistrations { get; set; }

        public virtual DbSet<Presenter> Presenters { get; set; }

        public virtual DbSet<Treatment> Treatments { get; set; }

        #region Required
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Event>()
        //        .HasMany<EventDay>(x => x.EventDays);

        //    modelBuilder.Entity<EventDay>()                
        //        .HasMany<TimeSlot>(x => x.TimeSlots);
        //}
        #endregion
    }
}