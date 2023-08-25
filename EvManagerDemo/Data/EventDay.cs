using Microsoft.EntityFrameworkCore;

namespace EvManagerDemo.Data
{
    [EntityTypeConfiguration(typeof(EventDayConfiguration))]
    public class EventDay
    {
        public EventDay()
        {
            TimeSlots = new List<TimeSlot>();
        }

        public Event Event { get; set; }

        public int EventDayId { get; set; }

        public DateTime Day { get; set;  }

        public string? Room { get; set; }

        public ICollection<TimeSlot> TimeSlots { get; set; }

        public string? Note { get; set; }
    }
}