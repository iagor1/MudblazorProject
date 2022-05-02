using AppCore.Model;
using Microsoft.EntityFrameworkCore;

namespace AppCore.Data
{
    public class EventContext: DbContext
    {
        public DbSet<Event> Events { get; set; } = default!;
        public EventContext(DbContextOptions<EventContext> options) : base(options) 
        { 
        }
    }
}
