using EvManagerDemo.Data;
using Microsoft.EntityFrameworkCore;

namespace EvManagerDemo.Services
{
    public class EventsService
    {
        private readonly ApplicationDbContext _context;

        public EventsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Event>> GetEventsAsync()
        {
            return await _context.Events.ToListAsync();
        }

        public async Task<Event> CreateEventAsync(Event e)
        {
            _context.Events.Add(e);

            await _context.SaveChangesAsync();

            return e;
        }
    }
}