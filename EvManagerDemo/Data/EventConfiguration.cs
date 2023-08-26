using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EvManagerDemo.Data
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder
                .HasMany(x => x.EventDays);
        }
    }

    public class EventDayConfiguration : IEntityTypeConfiguration<EventDay>
    {
        public void Configure(EntityTypeBuilder<EventDay> builder)
        {
            builder
                .HasMany(x => x.TimeSlots);
        }
    }

    public class EventRegistrationConfiguration : IEntityTypeConfiguration<EventRegistration>
    {
        public void Configure(EntityTypeBuilder<EventRegistration> builder)
        {
            builder
                .HasOne(x => x.Event);
        }
    }

    public class TreatmentConfiguration : IEntityTypeConfiguration<Treatment>
    {
        public void Configure(EntityTypeBuilder<Treatment> builder)
        {
            builder
                .Property(x => x.Cost).HasPrecision(2);
        }
    }
}
