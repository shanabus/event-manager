namespace EvManagerDemo.Data
{
    public class EventDay
    {
        public EventDay()
        {
            TimeSlots = new List<TimeSlot>();
        }

        public Event? Event { get; set; }

        public int EventDayId { get; set; }

        public DateTime Day { get; set;  }

        public string? Room { get; set; }

        public List<TimeSlot> TimeSlots { get; set; }

        public string? Note { get; set; }
    }
}