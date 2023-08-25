using System.ComponentModel.DataAnnotations;

namespace EvManagerDemo.Data
{
    public class Event
    {
        public Event()
        {
            EventDays = new List<EventDay>();
        }

        public int EventId {  get; set; }

        public List<EventDay> EventDays { get; set; }

        [Required]
        public string? Name { get; set;  }

        [Required]
        public string? Location { get; set; }
    }
}