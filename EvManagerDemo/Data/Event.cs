using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EvManagerDemo.Data
{
    [EntityTypeConfiguration(typeof(EventConfiguration))]
    public class Event
    {
        public Event()
        {
            EventDays = new List<EventDay>();
        }

        public int EventId {  get; set; }

        public ICollection<EventDay> EventDays { get; set; }

        [Required]
        public string? Name { get; set;  }

        [Required]
        public string? Location { get; set; }
    }
}