using System.ComponentModel.DataAnnotations;

namespace EvManagerDemo.Data
{
    public class Event
    {
        public int EventId {  get; set; }

        public List<EventDay>? EventDates { get; set; }

        [Required]
        public string? Name { get; set;  }

        [Required]
        public string? Location { get; set; }
    }
}