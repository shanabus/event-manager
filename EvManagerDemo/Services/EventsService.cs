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

        public async Task<Event?> GetEventAsync(int id)
        {
            return await _context.Events.Where(x => x.EventId == id).FirstOrDefaultAsync(x => x.EventId == id);
        }

        public async Task DeleteEventAsync(Event e)
        {
            _context.Events.Remove(e);

            await _context.SaveChangesAsync();
        }

        public async Task<Event> CreateEventAsync(Event e)
        {
            _context.Events.Add(e);

            await _context.SaveChangesAsync();

            return e;
        }

        public async Task<Event> UpdateEventAsync(Event e)
        {
            _context.Events.Update(e);

            await _context.SaveChangesAsync();

            return e;
        }
    }
}