namespace EvManagerDemo.Data
{
    public class EventDay
    {
        public required Event Event { get; set; }

        public int EventDayId { get; set; }

        public DateTime Day { get; set;  }

        public string? Room { get; set; }

        public List<TimeSlot>? Agenda { get; set; }

        public string? Note { get; set; }
    }
}