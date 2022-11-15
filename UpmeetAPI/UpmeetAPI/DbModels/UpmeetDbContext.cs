using Microsoft.EntityFrameworkCore;

namespace UpmeetAPI.DbModels
{
    public class UpmeetDbContext : DbContext
    {
        public UpmeetDbContext(DbContextOptions<UpmeetDbContext> options) : base(options) { }

        public DbSet<Event>Events { get; set; }
        public DbSet<FavoritedEvent> FavoritedEvents { get; set; }

    }
}
