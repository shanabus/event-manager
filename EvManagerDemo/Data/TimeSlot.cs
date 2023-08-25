namespace EvManagerDemo.Data
{
    public class TimeSlot
    {
        public int TimeSlotId { get; set; }

        public required EventDay Day { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string? Description { get; set; }
    }
}